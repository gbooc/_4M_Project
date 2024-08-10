using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_RIMP.Controllers
{
    public class My4MController : Controller
    {
        // GET: My4M
        public ActionResult My4M(string AccountType)
        {
            if (AccountType == "4MController")
            {
                return View("TD4MController");
            }
            else
            {
                return View("Department4M");
            }
        }
        public ActionResult Department4M()
        {
            return View();
        }

        public ActionResult TD4MController()
        {
            return View();
        }
    }
}