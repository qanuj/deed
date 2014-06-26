using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Deed.Web.ViewModels
{
    public class UpdateViewmodel
    {
        public long id { get; set; }
        public double  removeamount { get; set; }
        public double totalamount { get; set; }
        public int count { get; set; }
        public double simpleamount { get; set; }
    }
}