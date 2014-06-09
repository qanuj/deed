using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;

namespace Deed.Data.Model
{
    public class DeedUser : IdentityUser
    {
    }
    public class DeedDataContext : IdentityDbContext<DeedUser>
    {
        public DeedDataContext() : base("DBConnection") { }

        public DbSet<City> Cities { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gallary> Gallaries { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Spondership> Sponderships { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Widget> Widgets { get; set; }

    }
}
