using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using JavaScriptLab.Models;

namespace JavaScriptLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (string.IsNullOrEmpty(user.FirstName))
            {
                throw new ArgumentNullException("user","First Name is required");
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                throw new ArgumentNullException("user", "Last Name is required");
            }
            if (string.IsNullOrEmpty(user.MiddleName))
            {
                throw new ArgumentNullException("user", "Middle Name is required");
            }
            if (string.IsNullOrEmpty(user.AddressLineOne))
            {
                throw new ArgumentNullException("user", "Address Line One is required");
            }
            if (string.IsNullOrEmpty(user.City))
            {
                throw new ArgumentNullException("user", "City is required");
            }
            if (string.IsNullOrEmpty(user.State))
            {
                throw new ArgumentNullException("user", "State is required");
            }
            if (string.IsNullOrEmpty(user.Zip))
            {
                throw new ArgumentNullException("user", "Zip code is required");
            }
            if (string.IsNullOrEmpty(user.WorkPhone))
            {
                throw new ArgumentNullException("user", "Work phone is required");
            }
            if (string.IsNullOrEmpty(user.CellPhone))
            {
                throw new ArgumentNullException("user", "Cell phone is required");
            }
            if (string.IsNullOrEmpty(user.EmailAddress))
            {
                throw new ArgumentNullException("user", "Email address is required");
            }
            if (string.IsNullOrEmpty(user.UserId))
            {
                throw new ArgumentNullException("user", "User id is required");
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                throw new ArgumentNullException("user", "Password is required");
            }
            

            const string phoneRegex = @"^\D?(\d{3})\D?\D?(\d{3})\D?(\d{4})$";
            const string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"; 
            //The double ampersand in the expression @"^[\w-\.]+@@([\w-]+\.)+[\w-]{2,4}$" is ok in the controller but not in the Index.cshtml file
            
            if (!Regex.Match(user.WorkPhone, phoneRegex).Success)
            {
                throw new ArgumentException("Work phone number is not in correct format");
            }
            if (!Regex.Match(user.CellPhone, phoneRegex).Success)
            {
                throw new ArgumentException("Cell phone number is not in correct format");
            }
            if (!Regex.Match(user.EmailAddress, emailRegex).Success)
            {
                throw new ArgumentException("Email address is not in correct format");
            }

            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}