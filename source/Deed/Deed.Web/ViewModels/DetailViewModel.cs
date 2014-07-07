using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class DetailViewModel
    {
        public long StudentId{ get; set; }
        public string StudentName { get; set; }
        public string StudentImage { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public long DOB { get; set; }
        public string Religion { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string PostOffice { get; set; }
        public string PoliceStation { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Caste { get; set; }
        public string Picture { get; set; }
        public string History { get; set; }
        public string Class { get; set; }
        public string Tehsil { get; set; }
        public string Village { get; set; }
        public string FamilyHistory { get; set; }
        public double YearlyFee { get; set; }
        public double spestatus { get; set; }

        
        
        public double StudentFee { get; set; }
        public int StudentDOB { get; set; }
        public string StudentClass { get; set; }
        public string StudentCast { get; set; }

        public double TotalFee { get; set; }
    }
}