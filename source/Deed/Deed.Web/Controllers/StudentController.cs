using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Web.Models;

namespace Deed.Web.Controllers
{
    public class StudentController : Controller
    {
        DeedDataContext db = new DeedDataContext();
        //
        // GET: /Student/
        protected IQueryable<CardViewModel> Query()
        {
            var s = db.Students;
            var result = from r in s
                         select new CardViewModel
                             {
                                 Name = "ANNDY",
                                 District = "Mumbai",
                                 Adress = "Mumbai",
                                 Caste = "Hindu",
                                 City = "Mumbai",
                                 Country = "India",
                                 History = "",
                                 State = "Maharashtra",
                                 Religion = "Hindu",
                                 DOB = DateTime.Now,
                                 PostOffice = "Mumbai",


                             };
            return result;
        }

        public ActionResult Index()
        {
            return View(Query());
        }
	}
}