using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task3.Models;

namespace Task3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new Message { PlainText = "Hello, World!" };
            return View(model); 
        }

       
    }
}