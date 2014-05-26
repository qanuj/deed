using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Data.Objects;
using System.Data.Entity;
using Deed.Web.Models;

namespace Deed.Web.Controllers
{
    public class HomesController : Controller
    {
        //
        // GET: /Homes/
        public ActionResult StudentDetails(long id)
        {
            DeedDataContext dataContext = new DeedDataContext();
            Student student = dataContext.Students.Single(stu => stu.ID == id);


            return View(student);
        }
	}
}