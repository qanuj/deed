using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;

namespace Deed.Web.Controllers
{
    public class ProjectsController : DbController
    {
        //
        // GET: /Projects/

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

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SponsorProject()
        {
            return View();
        }

        public ActionResult SponsorChild()
        {

            return View(Query());
        }

        public ActionResult PartSponsor()
        {
            //var std = db.Students.OrderBy(x => x.first_name).Take(10);
            return View(Query());
        }


        public ActionResult SprtDeedADay()
        {
            return View();
        }

        public ActionResult ChildDetail(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            return View(s);

        }



	}
}