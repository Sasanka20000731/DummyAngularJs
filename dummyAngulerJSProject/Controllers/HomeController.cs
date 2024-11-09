using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dummyAngulerJSProject.Models;
using dummyAngulerJSProject.Services;  // Add this using statement

namespace dummyAngulerJSProject.Controllers
{
    public class HomeController : Controller
    {
        private IUserHandler userHandler; // Declare a variable of the interface type s

        public HomeController()
        {
            userHandler = new UserHandler(); // Initialize the variable with an instance of UserHandler
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(User user)
        {
            var Name = user.UserName.ToString();

            // Call the method through the interface
            string result = userHandler.ShowName(Name);

            // You can use 'result' in your view or return it to the view
            user.UserName = result;

            ViewBag.Title = result;

            return View("About",user);
        }
    }
}
