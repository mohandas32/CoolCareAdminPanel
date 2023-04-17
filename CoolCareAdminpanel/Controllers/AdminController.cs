using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoolCareAdminpanel.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult DashBoard()
        {
            return View();
        }

        public ActionResult UserDetail()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Packages()
        {
            return View();
        }

        public ActionResult Technician()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }
    }
}