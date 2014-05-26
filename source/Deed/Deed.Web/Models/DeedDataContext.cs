using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Deed.Data.Objects;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Deed.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
    }
    public class DeedDataContext : IdentityDbContext<ApplicationUser>
    {
        public DeedDataContext()
            : base("DBConnection")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}