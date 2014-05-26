using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Data.Objects;
using System.Data.Entity;
using Deed.Web.Models;
using Deed.Web.ViewModels;

namespace Deed.Web.Controllers
{
    public class HomesController : Controller
    {
        //
        // GET: /Homes/
        //public ActionResult StudentDetails(long id)
        //{
        //    DeedDataContext dataContext = new DeedDataContext();
        //    Student student = dataContext.Students.Single(stu => stu.ID == id);


        //    return View(student);
        //}

        DeedDataContext db = new DeedDataContext();
        //
        // GET: /Student/
        //protected IQueryable<CardViewModel> Query()
        //{
        //    var s = db.Students;
        //    var result = from r in s
        //                 select new CardViewModel
        //                 {
        //                     Name = "ANNDY",
        //                     District = "Mumbai",
        //                     Adress = "Mumbai",
        //                     Caste = "Hindu",
        //                     City = "Mumbai",
        //                     Country = "India",
        //                     History = "",
        //                     State = "Maharashtra",
        //                     Religion = "Hindu",
        //                     DOB = DateTime.Now,
        //                     PostOffice = "Mumbai",


        //                 };
        //    return result;
        //}

        //public ActionResult Index()
        //{
        //    return View(Query());
        //}
	}
}