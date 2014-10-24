using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityRoles.Models;
using Microsoft.AspNet.Identity;

namespace IdentityRoles.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var role = string.Empty;

            if (User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("user"))
                {
                    role = "user";
                }
                else if (User.IsInRole("superuser"))
                {
                    role = "superuser";
                }
                else
                {
                    role = "admin";
                }

                ViewBag.Message = "Your role is : " + role;
            }
            else
            {
                ViewBag.Message = "You are not logged in..";
            }

            return View();
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

        [Authorize(Roles = "user")]
        public ActionResult NormalUser()
        {
            ViewBag.Message = "Hello normal user.";

            return View();
        }
    }
}