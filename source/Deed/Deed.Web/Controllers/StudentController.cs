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

        //public ActionResult Query() {
        //    var students=db.Students.OrderByDescending(x=>x.id).Select(x=>new
        //    { last=x.last_name,picture=x.image,gender=x.male }).Take(10);
        //    return Json(students, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Videos() {
        //    var items = db.YouTubeVideos.OrderByDescending(x => x.id).Take(10);
        //    return vi(items, JsonRequestBehavior.AllowGet);
        //}

        public ActionResult Pledge()
        {
            var std = db.Students.OrderByDescending(x => x.id).Take(10);
            return View("Pledgge", std);
        }

        public ActionResult Videos()
        {
            var items = db.YouTubeVideos.OrderByDescending(x => x.id).Take(20);
            return View("Videogallery",items);
        }


        public ActionResult Photos()
        {
            var items = db.Students.OrderByDescending(x => x.id).Take(10);
            return View("Photogallery", items);
        }
       

        public ActionResult Photogallery()
        {
            return View(Videos());

        }

        public ActionResult Player(string linkk)
        {
            ViewBag.link = linkk;
            return View();

        }






        //Pledge Controller

        //public ActionResult PledgeIndex()
        //{ 
        //    return View(Query());
        
        //}
        public ActionResult PledgeDetail(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            return View(s);

        }

        
	}
}