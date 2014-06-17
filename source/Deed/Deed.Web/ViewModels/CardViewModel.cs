using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class CardViewModel
    {
        
        public long ID { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public DateTime DOB { get; set; }
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



    }
}