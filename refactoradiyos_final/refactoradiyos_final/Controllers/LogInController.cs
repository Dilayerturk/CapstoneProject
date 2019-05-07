using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace refactoradiyos_final.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Recover()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}