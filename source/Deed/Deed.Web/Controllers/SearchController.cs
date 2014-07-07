using Deed.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Deed.Web.Controllers
{
    public class SearchController : DbController
    {
        //
        // GET: /Search/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(long id)
        {
            
            ViewBag.Location = new SelectList(GetReligion(), "ID", "Name");

            var s = db.Students.FirstOrDefault(x => x.id == id);
            var bday = s.date_of_birth;
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--;
            var detailresult = (from std in db.Students
                                join cast in db.Casts on std.cast_id equals cast.id
                                join c in db.Clas on std.clas_id equals c.id
                                join f in db.Fees on std.id equals f.student_id



                                select new DetailViewModel
                                {
                                    StudentId = std.id,
                                    StudentName = std.first_name,
                                    Mother = std.mother_first_name,
                                    Father = std.father_first_name,
                                    Religion = std.religion,
                                    Adress1 = std.address_line1,
                                    Adress2 = std.address_line2,
                                    PostOffice = std.post_office,
                                    PoliceStation = std.police_station,
                                    District = std.district,
                                    City = std.city,
                                    State = std.state,
                                    StudentImage = std.image,
                                    FamilyHistory = std.family_history,
                                    Class = c.name,
                                    Caste = cast.name,
                                    Country = std.country,
                                    Tehsil = std.tehsil,
                                    Village = std.village,
                                    DOB = age,
                                    TotalFee = f.total_per_year / 90


                                }).FirstOrDefault(x => x.StudentId == id);

            return View(detailresult);
        }


       public ActionResult Get( int? page,int? Id,string StudentName,long? Location)
       {
           var pageNumber = page ?? 1;
           var s = from m in db.Students
                   join st in db.States on m.state equals st.name

                   select new SearchViewModel
                   {
                       StudentID = m.id,
                       StudentName = m.first_name,
                       StudentPic=m.image,
                       StudentLocation=st.id,
                       StudentFamilyHistory=m.family_history,
                       StudentFather=m.father_first_name,
                       StudentMother=m.mother_first_name

                   };


               s = s.Where(c => c.StudentName == StudentName ||c.StudentID==Id||c.StudentLocation==Location);
               s = s.OrderBy(x => x.StudentName);
               return View("SearchResult", s.ToPagedList(pageNumber,15));
          
       }


       public ActionResult FeaturedProject()
       {
           var projects = from std in db.Students
                          join f in db.SponsorPaymentHistories on std.id equals f.student_id into gh   

                          from sub in gh.DefaultIfEmpty()
                          select new DetailViewModel

                          {
                              StudentId = std.id,
                              StudentName = std.first_name + " " + std.last_name,
                              StudentImage=std.image,
                              FamilyHistory = std.family_history,
                              spestatus=std.sponsor_status
                              

                          };

           projects = projects.Where(x=>x.spestatus==1).OrderBy(x => x.StudentId).Take(4);
           return PartialView("FeaturedProject", projects);
       
       }

       public ICollection<ComboItem> GetReligion(string firstItem = "", long? selected = 0)
       {
           var r = from c in db.Students
                   join s in db.States on c.state equals s.name
                   select new ComboItem { ID=s.id ,Name = s.name };
           var result = r.Distinct().ToList();
           return result;
       }





	}
}