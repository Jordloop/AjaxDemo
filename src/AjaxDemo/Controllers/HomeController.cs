using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        //GET request using AJAX
        private AjaxDemoContext db = new AjaxDemoContext();
        public IActionResult RandomDestinationList(int destinationCount)
        {
            //Guid assures that destinations are returned in a random order
            //Take says how many destinations to put in randomDestinationList
            var randomDestinationList = db.Destinations.OrderBy(r => Guid.NewGuid()).Take(destinationCount);
            return Json(randomDestinationList);
        }
        
        //HttpPostAttribute requst using AJAX
        [HttpPost]
        public IActionResult NewDestination(string newCity, string newCountry)
        {
            Destination newDestination = new Destination(newCity, newCountry);
            db.Destinations.Add(newDestination);
            db.SaveChanges();
            return Json(newDestination);
        }


        //Basic AJAX request
        public IActionResult HelloAjax()
        {
            //This is the "result" used in the "sucess" function in the JS section 
                //Just like "View" is a return type, "Content" is also a return type.
            return Content("Hello from the controller!", "text/plain");
        }


        //AJAX request using parameters
        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }

        //AJAX request returning object
        public IActionResult DisplayObject()
        {
            //Creates a new destination object
            Destination destination = new Destination("Tokyo", "Japan", 1);
            //Returns destination as a Json response
            return Json(destination);
        }

        //AJAX request returning a view
        public IActionResult DisplayViewWithAjax()
        {
            return View();
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
