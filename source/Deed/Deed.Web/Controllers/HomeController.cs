using Deed.Web.Models;
using Deed.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers {
    public class HomeController : DbController {
        
        public ActionResult Query()
        {
            var s = db.Students;
            var result = from r in s
                         select new CardViewModel
                         {
                             ID=r.ID,
                             Name = r.Name+" "+r.Father+" "+r.Mother,
                             District = r.District,
                             Adress = r.Address,
                             Caste = r.Caste,
                             City = r.City,
                             Country = r.Country,
                             History = r.History,
                             State = r.State,
                             Religion = r.Religion,
                             DOB = DateTime.Now,
                             PostOffice = r.PostOffice,
                             Picture=r.Picture
                         
            };
            return PartialView("_Card",result);
            //return PartialView("_Card",s);
        }

        public ActionResult Search(string StudentName, string StudentReligion, string StudentCountry, string District)
        {
            var s = from m in db.Students select m;
            if (!String.IsNullOrEmpty(StudentName))
            {
                s = s.Where(c => c.Name==StudentName||c.Religion==StudentReligion||c.Country==StudentCountry||c.District==District);
            }
            return PartialView("_SearchResult", s);
        }


        public ActionResult StudentDetails(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.ID == id);
            return View("StudentDetails", s);

        }




        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View();
        }

    }
}
