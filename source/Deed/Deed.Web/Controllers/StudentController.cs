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
        readonly Deed.Data.Legacy.DataContext db = new Data.Legacy.DataContext();

        public ActionResult Query() {
            var students=db.Students.OrderByDescending(x=>x.id).Select(x=>new
            { last=x.last_name,picture=x.image,gender=x.male }).Take(10);
            return Json(students, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Videos() {
            var items = db.YouTubeVideos.OrderByDescending(x => x.id).Take(10);
            return Json(items, JsonRequestBehavior.AllowGet);
        }
	}
}