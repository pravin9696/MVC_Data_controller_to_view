using MVC_Data_controller_to_view.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Data_controller_to_view.Controllers
{
    public class GTHController : Controller
    {
        // GET: GTH
        public ActionResult Index()
        {
            return View("MyIndex");
        }
        public ActionResult MyMethod()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public String getLoginDetails(string userid, string password)
        {
            if (userid == "Admin" && password == "Admin@123")
            {
                return "Valid user....";
            }
            else
            {
                return "Invalid user!!!!!!";
            }
        }

        public string getLoginByRequest()
        {
            string id = Request["userid"];
            string pass = Request["password"];
            if (id == "Admin" && pass == "Admin@123")
            {
                return "Valid user....";
            }
            else
            {
                return "Invalid user!!!!!!";
            }
        }

        public string getUsingformCollection(FormCollection form)
        {
            string id = form["userid"];
            string pass = form["password"];
            if (id == "Admin" && pass == "Admin@123")
            {
                return "Valid user....";
            }
            else
            {
                return "Invalid user!!!!!!";
            }
        }

        public ActionResult login1()
        {
            return View();
        }
        public string checkLogin(login lg)
        {
            string id = lg.userid;
            string pass = lg.password;
            if (id == "Admin" && pass == "Admin@123")
            {
                return "Valid user....";
            }
            else
            {
                return "Invalid user!!!!!!";
            }
        }

    }
}