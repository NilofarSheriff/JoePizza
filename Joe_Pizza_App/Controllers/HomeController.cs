using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Joe_Pizza_App.Models;

namespace Joe_Pizza_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserDetails user = new UserDetails();

            return View(user);
        }
        [HttpPost]
        public ActionResult Index(UserDetails newuser)
        {
            var userd = loginvalues().Where(x => x.UserName == newuser.UserName && 
            x.UserPassword==newuser.UserPassword).FirstOrDefault() ;
            if(userd!= null)
            {
                ViewBag.Status = "Sucessfully Logged In";
            }
            else
            {
                ViewBag.Status = "Incorrect User Details";
            }

            return View(newuser);
        }
        public List<UserDetails> loginvalues()
        {
            List<UserDetails> objModel = new List<UserDetails>();
            objModel.Add(new UserDetails { UserName = "Nilo", UserPassword = "Nilo@123" });
            objModel.Add(new UserDetails { UserName = "Zam", UserPassword = "Zam@123" });
            objModel.Add(new UserDetails { UserName = "Asif", UserPassword = "Asif@123" });
            objModel.Add(new UserDetails { UserName = "Mehar", UserPassword = "Mehar@123" });
            objModel.Add(new UserDetails { UserName = "Sheriff", UserPassword = "Sheriff@123" });
            return objModel;
        }
    }
}
