using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HelloAjax()
        {
            //This is the "result" used in the "sucess" function in the JS section 
                //Just like "View" is a return type, "Content" is also a return type.
            return Content("Hello from the controller!", "text/plain");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
