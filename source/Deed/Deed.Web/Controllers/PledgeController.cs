using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Legacy;

namespace Deed.Web.Controllers
{
    public class PledgeController : DbController
    {
        //
        // GET: /Pledge/
        public ActionResult Index()
        {
            return View(Query());
        }

        public ActionResult PledgeIndex()
        {
            return View();
        }


        public ActionResult Details(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            return View(s);

        }

        public ActionResult slid()
        {
            
            return View();

        }

        protected IQueryable<CardViewModel> Query()
        {
            var query = from r in db.Students

                        select new CardViewModel
                        {
                            ID = r.id,
                            Name = r.first_name,
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
                            PoliceStation = r.police_station

                        };
            query = query.OrderBy(x => x.Name).Take(10);
            return query;
            
        }

        public ActionResult Cart(long[] Selected)
        {
            var stu=new List<Student>();
            
            foreach (var i in Selected)
            {

                var s = db.Students.FirstOrDefault(r => r.id==i);

                stu.Add(s);

            }


            return View(stu);
            
        }

        //public ActionResult Cart()
        //{
        //    return View();
        //}






	}
}