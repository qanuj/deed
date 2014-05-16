using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deed.Data.Objects {

    public class Person {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public bool IsFeatured { get; set; }
        public IList<Spondership> Sponderships { get; set; }
    }

    public class Spondership {
        public long ID { get; set; }
        public Student Student { get; set; }
        public long StudentID { get; set; }
        public Person Sponsor { get; set; }
        public long SponsorID { get; set; }
        public DateTime Start {get;set;}
        public DateTime End { get; set; }
        public Double Amount { get; set; }
        public string Currency { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Student {
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

    public class Contact {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Message { get; set; }
    }

    public class Widget {
        public long ID { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Html)]
        public string Body { get; set; }
        public int Sequence { get; set; }
        public bool IsAll { get; set; }
        public bool IsHome { get; set; }
        public bool IsInternal { get; set; }
        public bool IsSecured { get; set; }
        public bool IsAnonmous { get; set; }
    }

    public class Page : Widget {
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDraft { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Config {
        public long ID { get; set; }
        public string Hosts { get; set; }//csv
        public string Data { get; set; }//JSON
    }

    public class Gallary : Page { }
    public class Story : Page { }
    public class News : Page {}

    public class Religion : Master { }
    public class City : Master { }
    public class Country : Master { }
    public class State : Master { }
    public class Master {
        public long ID {get;set;}
        public string Name {get;set;}
    }

}
