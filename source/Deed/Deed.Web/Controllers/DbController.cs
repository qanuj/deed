using Deed.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class DbController : Controller
    {
        private DeedDataContext _db;
        protected DeedDataContext db
        {
            get
            {
                if (_db == null)
                {
                    _db = new DeedDataContext();
                    //_db.My = my;
                }
                return _db;
            }
        }
        
	}
}