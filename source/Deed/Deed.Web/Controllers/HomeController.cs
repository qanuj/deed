using Deed.Web.Models;
using Deed.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Data.Objects;

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
                             City = r.City.Name,
                             Country = r.Country.Name,
                             History = r.History,
                             State = r.State.Name,
                             Religion = r.Religion.Name,
                             DOB = DateTime.Now,
                             PostOffice = r.PostOffice,
                             Picture=r.Picture
                         
            };
            return PartialView("_Card",result);
            //return PartialView("_Card",s);
        }

        public ActionResult Search(string StudentName, string Religion, string Country, string State)
        {
            if (!String.IsNullOrEmpty(StudentName))
            {
                var Re = Convert.ToInt64(Religion);
                var Co = Convert.ToInt64(Country);
                var St = Convert.ToInt64(State);
                var s = from m in db.Students select m;
                s = s.Where(c => c.Name == StudentName || c.Religion.ID == Re || c.Country.ID == Co || c.State.ID == St);
                return PartialView("_SearchResult", s);
            }
            return RedirectToAction("Index");
        }


        public ActionResult StudentDetails(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.ID == id);
            return View("StudentDetails", s);

        }

        public ActionResult Index() 
        {
            ViewBag.Title = "Home Page";
            ViewBag.Religion = new SelectList(GetReligion(), "ID", "Name");
            ViewBag.Country = new SelectList(GetCountry(),"ID","Name");
            ViewBag.State = new SelectList(GetState(), "ID", "Name");
            ViewBag.City = new SelectList(GetCity(), "ID", "Name");
            return View();
        }

        public ICollection<ComboItem> GetReligion(string firstItem = "", long? selected = 0)
        {
            var r = from c in db.Students select new ComboItem { ID = c.Religion.ID, Name = c.Religion.Name };
            var result = r.Distinct().ToList();
            return result;
        }

        public ICollection<ComboItem> GetCountry(string firstItem = "", long? selected = 0)
        {
            var r = from c in db.Students select new ComboItem { ID = c.Country.ID, Name = c.Country.Name };
            var result = r.Distinct().ToList();
            return result;
        }

        public ICollection<ComboItem> GetState(string firstItem = "", long? selected = 0)
        {
            var r = from c in db.Students select new ComboItem { ID = c.State.ID, Name = c.State.Name };
            var result = r.Distinct().ToList();
            return result;
        }
        public ICollection<ComboItem> GetCity(string firstItem = "", long? selected = 0)
        {
            var r = from c in db.Students select new ComboItem { ID = c.City.ID, Name = c.City.Name };
            var result = r.Distinct().ToList();
            return result;
        }

    }
}
