using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Legacy;

namespace Deed.Web.Controllers
{
    public class PledgeController : DbController
    {
        //
        // GET: /Pledge/
        public ActionResult Index()
        {
            return View(Query());
        }

        public ActionResult PledgeIndex()
        {
            return View();
        }


        public ActionResult Details(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            return View(s);

        }

        public ActionResult slid()
        {
            
            return View();

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
            query = query.OrderBy(x => x.Name).Take(10);
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
            int count = 0;
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
                Std.Add(s);
                ++count;

            }
            var r = new SponsorPaymentViewModel
            {

               Students=Std,
               count=count
               

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