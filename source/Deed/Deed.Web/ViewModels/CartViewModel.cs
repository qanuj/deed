using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class CartViewModel
    {
        public long StudentId { get; set; }
        public string  StudentName  { get; set; }
        public string  StudentImage { get; set; }
        public double StudentFee { get; set; }
        public DateTime StudentDOB { get; set; }
        public string StudentClass { get; set; }
        public double TotalFee{get;set;}
        
    }
}