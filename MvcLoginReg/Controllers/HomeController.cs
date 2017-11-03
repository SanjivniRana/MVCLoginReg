using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLoginReg.Models;
using System.Net;
using System.Data.SqlClient;
using System.Configuration;

namespace MvcLoginReg.Controllers
{
    public class HomeController : Controller
    {
        UsersContext context = new UsersContext();


        [HttpGet]
        public ActionResult Welcome()
        {

            return View();
        }

        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }

        

        [HttpPost]
        public ActionResult Index(Models.User user)
        {

            if (IsValid(user.Userid, user.Password))
            {
                //FormsAuthentication.SetAuthCookie(user.Email, false);
                return RedirectToAction("Welcome", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Login details are wrong.");
            }
            return View(user);
        }

        
        private bool IsValid(string userid, string password)
        {
            //var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;

            
                var user = context.Users.FirstOrDefault(u => u.Userid == userid);

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        IsValid = true;
                    }
                }
            
            return IsValid;
        }

        


        public ActionResult Register()
        {
            ViewBag.Message = "Registration";

            return View();
        }

        [HttpPost, ActionName("Register")]
        public ActionResult Register(Models.User user)
        {

            if (IsValidReg(user.ConformPassword, user.Password))
            {

                context.Users.Add(user);
                context.SaveChanges();

                //FormsAuthentication.SetAuthCookie(user.Email, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Password not matched.");
            }
            return View(user);
        }

        
        private bool IsValidReg(string ConformPassword, string password)
        {
            //var crypto = new SimpleCrypto.PBKDF2();
            bool IsValid = false;


                if (ConformPassword == password)
                {
                    IsValid = true;
                }
      

            return IsValid;
        }



    }
}