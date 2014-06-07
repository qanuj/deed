using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class MediaController : Controller
    {
        //
        // GET: /Media/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photos()
        {
            return View();
        }

        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult AnnualEvents()
        {
            return View();
        }

	}
}