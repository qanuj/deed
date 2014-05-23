using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class Student
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public DateTime? Birthday { get; set; }
        public string Class { get; set; }
        public string Religion { get; set; }
        public string Address { get; set; }
        public string Village { get; set; }
        public string PostOffice { get; set; }
        public string PuliceStation { get; set; }
        public string District { get; set; }
        public string Caste { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string History { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public Double Target { get; set; }
        public string Currency { get; set; }
        public DateTime Added { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAchieved { get; set; }
        public IList<Spondership> Sponderships { get; set; }
    }
}
