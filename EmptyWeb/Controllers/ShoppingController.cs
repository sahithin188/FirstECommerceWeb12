using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyWeb.Controllers
{
    public class ShoppingController: Controller
    {
        public string Index()
        {
            return "Hello world from shopping";
        }
    }
}
