using Deed.Web.Models;
using Deed.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers {
    public class HomeController : Controller {
        DeedDataContext db = new DeedDataContext();

        public ActionResult Query()
        {
            var s = db.Students;
            var result = from r in s
                         select new CardViewModel
                         {
                             Name = r.Name,
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
            //return PartialView("_Card",s);
            return PartialView("_Card",result);
        }
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View();
        }

    }
}
