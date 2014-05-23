using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Spondership
    {
        public long ID { get; set; }
        public Student Student { get; set; }
        public long StudentID { get; set; }
        public Person Sponsor { get; set; }
        public long SponsorID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Double Amount { get; set; }
        public string Currency { get; set; }
        public bool IsFeatured { get; set; }
    }
}
