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
            return View(Query().ToPagedList(pageNumber,10));
        }

        public ActionResult PledgeIndex()
        {
            return View();
        }


        public ActionResult Details(long id)

        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            if (Request.IsAjaxRequest())
            {

               Session["CartStudent"] = (from std in db.Students
                                  join fee in db.Fees on std.id equals fee.student_id

                                  join c in db.Clas on std.clas_id equals c.id

                                  select new CartViewModel
                                  {
                                      StudentId = std.id,
                                      StudentName = std.first_name,
                                      StudentDOB = std.date_of_birth,
                                      StudentImage = std.image,
                                      StudentClass = c.name,
                                      StudentFee= fee.school_fees/90


                                  }).FirstOrDefault(x=>x.StudentId==id);


               return Json(Session["CartStudent"], JsonRequestBehavior.AllowGet);
            }
            
            return View(s);

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
                            Name = r.first_name,
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
                            PoliceStation = r.police_station

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
            //if (ModelState.IsValid)
            //{
            //    var clientProfile = new ClientProfile { 
                
            //    address_line1=objSprPayViewModel.AddressLine1,
            //    address_line2=objSprPayViewModel.addessLine2,
            //    city=objSprPayViewModel.City,
            //    state=objSprPayViewModel.State,
            //    country=objSprPayViewModel.CardIssuingCountry

            //    };
            //    db.ClientProfiles.Add(clientProfile);
            //}
            foreach (var i in objSprPayViewModel.StudentId)
            {

                var s = db.Students.FirstOrDefault(g => g.id == i);
                //Std.Add(s);
                //++count;
                
                var cart = (from std in db.Students
                                          join fee in db.Fees on std.id equals fee.student_id

                                          join c in db.Clas on std.clas_id equals c.id

                                          select new CartViewModel
                                          {
                                              StudentId = std.id,
                                              StudentName = std.first_name,
                                              StudentDOB = std.date_of_birth,
                                              StudentImage = std.image,
                                              StudentClass = c.name,
                                              StudentFee = fee.school_fees / 90,
                                              TotalFee = total + fee.school_fees / 90


                                          }).FirstOrDefault(x => x.StudentId == i);

                cartlist.Add(cart);
                ++count;
                

            }
            foreach(var m in cartlist)
            {
                total = total + m.StudentFee;

            }
            var r = new SponsorPaymentViewModel
            {

               Students=Std,
               CartItems=cartlist,
               count=count,
               total_amount=total

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



	}
}