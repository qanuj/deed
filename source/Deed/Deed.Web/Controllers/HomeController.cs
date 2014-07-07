﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Legacy;
using PagedList;

namespace Deed.Web.Controllers {
    public class HomeController : DbController {
        public ActionResult Index()
        {
            ViewBag.Country = new SelectList(GetCountry(), "ID", "Name");
            ViewBag.State = new SelectList(GetState(), "ID", "Name");
            ViewBag.City = new SelectList(GetCity(), "ID", "Name");
            return View();
        }
        
        public ActionResult Query(int? page)
        {
            var pageNumber = page ?? 1;
            var result = from r in db.Students
                         select new CardViewModel
                         {
                             ID = r.id,
                             Name = r.first_name + "   " + r.last_name,
                             Father = r.father_first_name,
                             Mother = r.mother_first_name,
                             District = r.district,
                             Adress1 = r.address_line1,
                             Adress2 = r.address_line2,
                             //Caste = r.cast_id,
                             City = r.city,
                             Country = r.country,
                             History = r.family_history,
                             State = r.state,
                             Religion = r.religion,
                             DOB = DateTime.Now,
                             PostOffice = r.post_office,
                             Picture = r.image,
                             PoliceStation = r.police_station,
                             FamilyHistory = r.family_history
                       
            };

            result = result.OrderBy(x => x.Name).Take(4);
            return PartialView("_Card", result.ToPagedList(pageNumber, 4));
        }

        public ActionResult Get(int? page,string StudentFirstName,string StudentLastName, long? State,long? Country,string City)
        {
           
            
            var pageNumber = page ?? 1;
            var s = from m in db.Students
                    join st in db.States on m.state equals st.name
                    
                    select new SearchViewModel
                    {
                        StudentID = m.id,
                        StudentName=m.first_name+" "+m.last_name,
                        StudentFirstName = m.first_name,
                        StudentLastName=m.last_name,
                        StudentPic = m.image,
                        StudentLocation = st.id,
                        StudentFamilyHistory = m.family_history,
                        StudentFather = m.father_first_name,
                        StudentMother = m.mother_first_name
                        

                    };


            s = s.Where(c => c.StudentFirstName == StudentFirstName ||c.StudentLastName==StudentLastName|| c.StudentLocation == State);
            s = s.OrderBy(x => x.StudentFirstName);
            return View("SearchResult", s.ToPagedList(pageNumber, 15));

        }

        public ICollection<ComboItem> GetCountry(string firstItem = "", long? selected = 0)
        {
            var r = from c in db.Countries 
                    
                    select new ComboItem { ID = c.id, Name = c.name };
            var result = r.Distinct().ToList();
            return result;
        }

        public ICollection<ComboItem> GetState(string firstItem = "", long? selected = 0)
        {
            var r = from s in db.Students 
                    join sta in db.States on s.state equals sta.name
                    select new ComboItem {ID = sta.id, Name =sta.name };
            var result = r.Distinct().ToList();
            return result;
        }
        public ICollection<ComboItem> GetCity(string firstItem = "", long? selected = 0)
        {
            var r = from s in db.Students 
                    
                    select new ComboItem {  StringID=s.city, Name = s.city};
            var result = r.Distinct().ToList();
            return result;
        }

    }
}
//        public ActionResult Search(string StudentName, string Religion, string Country, string State)
//        {
//            if (!String.IsNullOrEmpty(StudentName))
//            {
//                var Re = Convert.ToInt64(Religion);
//                var Co = Convert.ToInt64(Country);
//                var St = Convert.ToInt64(State);
//                var s = from m in db.Students select m;
//                s = s.Where(c => c.Name == StudentName || c.Religion.ID == Re || c.Country.ID == Co || c.State.ID == St);
//                return View("SearchResult", s);
//            }
//            return RedirectToAction("Index");
//        }


//        public ActionResult StudentDetails(long id)
//        {
//            var s = db.Students.FirstOrDefault(x => x.ID == id);
//            return View("StudentDetails", s);

//        }

//        public ActionResult Index() 
//        {
//            ViewBag.Title = "Home Page";
//            ViewBag.Religion = new SelectList(GetReligion(), "ID", "Name");
//            ViewBag.Country = new SelectList(GetCountry(),"ID","Name");
//            ViewBag.State = new SelectList(GetState(), "ID", "Name");
//            ViewBag.City = new SelectList(GetCity(), "ID", "Name");
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

//        public ICollection<ComboItem> GetState(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students select new ComboItem { ID = c.State.ID, Name = c.State.Name };
//            var result = r.Distinct().ToList();
//            return result;
//        }
//        public ICollection<ComboItem> GetCity(string firstItem = "", long? selected = 0)
//        {
//            var r = from c in db.Students select new ComboItem { ID = c.City.ID, Name = c.City.Name };
//            var result = r.Distinct().ToList();
//            return result;
//        }

//        //public ActionResult Index()
//        //{
            
//        //    return View();
//        //}

//    }
//}

