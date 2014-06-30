using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Legacy;
using PagedList;

namespace Deed.Web.Controllers
{
    public class PledgeController : DbController
    {
        //
        // GET: /Pledge/
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            return View(Query().ToPagedList(pageNumber,15));
        }

        public ActionResult PledgeIndex()
        {
            return View();
        }


        public ActionResult Details(long id)

        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            var bday = s.date_of_birth;
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--;
            var detailresult = (from std in db.Students 
                                join cast in db.Casts on std.cast_id equals cast.id
                                join c in db.Clas on std.clas_id equals c.id
                                join f in db.Fees on std.id equals f.student_id

                                

                                select new DetailViewModel
                                {
                                    StudentId=std.id,
                                    StudentName=std.first_name,
                                    Mother=std.mother_first_name,
                                    Father=std.father_first_name,
                                    Religion=std.religion,
                                    Adress1=std.address_line1,
                                    Adress2=std.address_line2,
                                    PostOffice=std.post_office,
                                    PoliceStation=std.police_station,
                                    District=std.district,
                                    City=std.city,
                                    State=std.state,
                                    StudentImage=std.image,
                                    FamilyHistory=std.family_history,
                                    Class=c.name,
                                    Caste=cast.name,
                                    Country=std.country,
                                    Tehsil=std.tehsil,
                                    Village=std.village,
                                    DOB=age,
                                    TotalFee=f.total_per_year/90
                                    

                                }).FirstOrDefault(x => x.StudentId == id);

            

            if (Request.IsAjaxRequest())
            {
                
               
               Session["CartStudent"] = (from std in db.Students
                                  join fee in db.Fees on std.id equals fee.student_id

                                  join c in db.Clas on std.clas_id equals c.id

                                  select new CartViewModel
                                  {
                                      StudentId = std.id,
                                      StudentName = std.first_name,
                                      StudentDOB = age,
                                      StudentImage = std.image,
                                      StudentClass = c.name,
                                      StudentFee= fee.total_per_year/90


                                  }).FirstOrDefault(x=>x.StudentId==id);


               return Json(Session["CartStudent"], JsonRequestBehavior.AllowGet);
            }
            
            return View(detailresult);

        }

        public ActionResult slid()
        {
            var model = Session["CartStudent"];
            
            return View(model);

        }
        public ActionResult Spr()
        {

            return Json(Session["CartStudent"], JsonRequestBehavior.AllowGet);

        }

        protected IQueryable<CardViewModel> Query()
        {
            var query = from r in db.Students

                        select new CardViewModel
                        {
                            ID = r.id,
                            Name = r.first_name + "   " + r.last_name ,
                            Father = r.father_first_name,
                            Mother = r.mother_first_name,
                            District = r.district,
                            Adress1 = r.address_line1,
                            Adress2 = r.address_line2,
                            //Caste = r.cast_id,
                            City = r.city,
                            Country = r.country,
                            History = r.family_history,
                            State = r.state,
                            Religion = r.religion,
                            DOB = DateTime.Now,
                            PostOffice = r.post_office,
                            Picture = r.image,
                            PoliceStation = r.police_station,
                            FamilyHistory=r.family_history
                            

                        };
            query = query.OrderBy(x => x.Name);
            return query;
            
        }

        public ActionResult Cart(long[] Selected)
        {

            List<string> listImage = new List<string>();
            List<long> listStudentId = new List<long>();
            foreach (var i in Selected)
            {

                var s = db.Students.FirstOrDefault(g => g.id == i);
                listImage.Add(s.image);
                listStudentId.Add(s.id);



            }
            var r = new SponsorPaymentViewModel
            {

                Picture = listImage,
                StudentId=listStudentId

            };

            return View(r);

        }

        [HttpPost]
        public ActionResult Sponsorr(SponsorPaymentViewModel objSprPayViewModel)
        {
            List<string> listImage = new List<string>();
            List<Student> Std = new List<Student>();
            List<CartViewModel>cartlist=new List<CartViewModel>();
            int count = 0;
            double total = 0;
            double simpletotal = 0;
            
            foreach (var i in objSprPayViewModel.StudentId)
            {

                var s = db.Students.FirstOrDefault(g => g.id == i);
                

                var bday = s.date_of_birth;
                DateTime today = DateTime.Today;
                int age = today.Year - bday.Year;
                if (bday > today.AddYears(-age)) age--;
                
                var cart = (from std in db.Students
                                          join fee in db.Fees on std.id equals fee.student_id

                                          join c in db.Clas on std.clas_id equals c.id

                                          select new CartViewModel
                                          {
                                              StudentId = std.id,
                                              StudentName = std.first_name,
                                              StudentDOB = age,
                                              StudentImage = std.image,
                                              StudentClass = c.name,
                                              StudentFee = fee.total_per_year/90
                                              


                                          }).FirstOrDefault(x => x.StudentId == i);

                cartlist.Add(cart);

                Session.Add("Carts", cartlist);
                ++count;
                

            }
            cartlist = (List<CartViewModel>)Session["Carts"];
            foreach(var m in cartlist)
            {
                total = total + m.StudentFee;

            }
            simpletotal = total;
            total = total + total * 5 / 100;
            var r = new SponsorPaymentViewModel
            {

               Students=Std,
               CartItems=cartlist,
               count=count,
               total_amount=Math.Round(total,2),
               SimpleTotal=simpletotal
            };
            return View(r);
        }


        public ActionResult PayNext(List<long> Selected)
        {
            List<Student> Std = new List<Student>();
            foreach (var i in Selected)
            {

                var s = db.Students.FirstOrDefault(g => g.id == i);
                Std.Add(s);



            }
            var r = new SponsorPaymentViewModel
            {

                Students = Std
                

            };
            return View("Sponsorr",r);
        }

        public ActionResult Remove(UpdateViewmodel objUpdate)
        {
            objUpdate.simpleamount = objUpdate.simpleamount - objUpdate.removeamount;
            objUpdate.totalamount = objUpdate.simpleamount + objUpdate.simpleamount * 5 / 100;
            objUpdate.count = objUpdate.count-1;

            if (objUpdate.count==0)
            {
                objUpdate.totalamount = 0.00;

                objUpdate.count = 0;

            }
            

            return Json(objUpdate,JsonRequestBehavior.AllowGet);
        }


	}
}