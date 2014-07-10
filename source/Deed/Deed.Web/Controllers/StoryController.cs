using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class StoryController : DbController
    {
        //
        // GET: /Story/
        public ActionResult Index(long id)
        {
            var s = db.Stories.FirstOrDefault(x => x.id == id);
            return View("Index",s);
        }

        public ActionResult Get(long id)
        {
            var s = db.Stories.FirstOrDefault(x => x.id == id);
            return View("Index", s);
        }
	}
}