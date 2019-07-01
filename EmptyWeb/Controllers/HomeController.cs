using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyWeb.Controllers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "Hello world from MVC";
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}
