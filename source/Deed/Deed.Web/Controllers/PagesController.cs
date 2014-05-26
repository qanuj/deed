using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Do()
        {
            return View();
        }
	}
}