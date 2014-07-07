﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Deed.Web.ViewModels;
using Deed.Data.Legacy;
using PagedList;

namespace Deed.Web.Controllers
{
    public class ProjectsController : DbController
    {
        //
        // GET: /Projects/

        public ActionResult PartSponsor(int? page)
        {
            var pageNumber = page ?? 1;
            return View(Query().ToPagedList(pageNumber, 15));
        }

        protected IQueryable<CardViewModel> Query()
        {
            var query = from r in db.Students

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
            query = query.OrderBy(x => x.Name);
            return query;

        }

        
        public ActionResult SponsorProject()
        {
            return View();
        }

        public ActionResult SponsorChild()
        {

            return View(Query());
        }

        


        public ActionResult SprtDeedADay()
        {
            return View();
        }

        public ActionResult ChildDetail(long id)
        {
            var s = db.Students.FirstOrDefault(x => x.id == id);
            return View(s);

        }



	}
}