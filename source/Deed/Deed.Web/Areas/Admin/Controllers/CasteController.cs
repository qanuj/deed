//using System;
//using Deed.Data.Objects;
//using Deed.Web.Controllers;
//using System.Collections.Generic;
//using System.Linq;
//using System.Data.Entity;
//using System.Web;
//using System.Web.Mvc;
//using Deed.Web.Models;

//namespace Deed.Web.Areas.Admin.Controllers
//{
//    public class CasteController : DbController
//    {
//        //
//        // GET: /Admin/Caste/
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult Create()
//        {
            
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Create(Student objStudent)
//        {
//            if (objStudent.ID > 0)
//            {
//                ViewBag.Title = "Edit";
//                db.Entry<Student>(objStudent).State = EntityState.Modified;
//                db.SaveChanges();
//            }

//            else
//            {
//                ViewBag.Title = "Create";
//                db.Students.Add(objStudent);
//                db.SaveChanges();
//                return View("Create");
//            }
//            return View("Create");
//        }
//    }
//}