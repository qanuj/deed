using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class SearchViewModel
    {
        public long  StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentPic { get; set; }
        public long  StudentLocation { get; set; }
        public string StudentFamilyHistory { get; set; }
        public string StudentFather { get; set; }
        public string StudentMother { get; set; }

        public long StudentCountry { get; set; }
    }
}


