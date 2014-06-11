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
//    public class StudentController : DbController
//    {
//        //
//        // GET: /Admin/Student/
//        public ActionResult Index()
//        {
            
//            //ViewBag.State = new SelectList(GetState(), "ID", "Name");
//            //ViewBag.City = new SelectList(GetCity(), "ID", "Name");
//            return View();
//        }
//        public ICollection<ComboItem> GetReligion(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students select new ComboItem { ID = c.Religion.ID, Name = c.Religion.Name };
//            var result = r.Distinct().ToList();
//            return result;
//        }

//        public ICollection<ComboItem> GetCountry(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students select new ComboItem { ID = c.Country.ID, Name = c.Country.Name };
//            var result = r.Distinct().ToList();
//            return result;
//        }

//        public List<string> GetCaste(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students orderby c.Caste select c.Caste;
//            var result = r.Distinct().ToList();
//            return result;
//        }

//        public List<string> GetClass(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students orderby c.Class select c.Class;
//            var result = r.Distinct().ToList();
//            return result;
//        }
//        public ActionResult Create()
//        {
//            ViewBag.Religion = new SelectList(GetReligion(), "ID", "Name");
//            ViewBag.Country = new SelectList(GetCountry(), "ID", "Name");
//            ViewBag.Class = new SelectList(GetClass());
//            ViewBag.Caste = new SelectList(GetCaste());
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

//        public ActionResult Edit(long id)
//        {
//            var p = db.Students.FirstOrDefault(x => x.ID == id);
//            return View("Create", p);

//        }

//        public ActionResult Delete(long id)
//        {
//            var p = db.Students.FirstOrDefault(x => x.ID == id);
//            return PartialView("PeopleDelete", p);
//        }
//    }
//}