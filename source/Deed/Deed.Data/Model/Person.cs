using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Person
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public bool IsFeatured { get; set; }
        public IList<Spondership> Sponderships { get; set; }
    }
}
