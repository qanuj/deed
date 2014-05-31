using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Objects;

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

        public ActionResult Details(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.ID == id);
            return View(s);

        }
        protected IQueryable<CardViewModel> Query()
        {
            var query = from r in db.Students

                        select new CardViewModel
                        {
                            ID = r.ID,
                            Name = r.Name + " " + r.Father + " " + r.Mother,
                            Father=r.Father,
                            Mother=r.Mother,
                            District = r.District,
                            Adress = r.Address,
                            Caste = r.Caste,
                           // City = r.City.Name,
                            //Country = r.Country.Name,
                            History = r.History,
                            //State = r.State.Name,
                            //Religion = r.Religion.Name,
                            DOB = DateTime.Now,
                            PostOffice = r.PostOffice,
                            Picture = r.Picture

                        };

            return query;
            
        }
	}
}