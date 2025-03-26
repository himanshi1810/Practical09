using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Controllers
{
    public class HomeController : Controller
    {
        //For displaying Hello World with my mvc Project
        // GET: Home
        public ActionResult Index()
        {
            return Content("Hello World");
        }
    }
}