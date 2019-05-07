using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace refactoradiyos_final.Controllers
{
    public class MailComposeController : Controller
    {
        // GET: MailCompose
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inbox()
        {
            return View();
        }
    }
}