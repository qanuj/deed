using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Page : Widget
    {
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDraft { get; set; }
        public bool IsFeatured { get; set; }
    }
}
