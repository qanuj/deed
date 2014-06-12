using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class MediaController : DbController
    {
        //
        // GET: /Media/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Photos()
        {
            var items = db.Students.OrderBy(x => x.first_name).Take(10);
            return View(items);
        }

        public ActionResult Videos()
        {
            var items = db.YouTubeVideos.OrderByDescending(x => x.id).Take(20);
            return View(items);
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult AnnualEvents()
        {
            var items = db.YouTubeVideos.OrderByDescending(x => x.id).Take(20);
            return View(items);
        }

        public ActionResult Player(string linkk)
        {
            ViewBag.link = linkk;
            return View();

        }


	}
}