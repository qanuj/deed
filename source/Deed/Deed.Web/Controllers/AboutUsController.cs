using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deed.Web.Controllers
{
    public class AboutUsController : Controller
    {
        //
        // GET: /AboutUs/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhatWeDo()
        { 
            return View();
        }

        public ActionResult HowItWorks()
        { 
            return View();
        }

        public ActionResult EthicsAndCulture()
        {
            return View();
        }
	}
}