using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace refactoradiyos_final.Controllers
{
    public class TablesEditableController : Controller
    {
        NewAdiyosEntities2 aDIYOS = new NewAdiyosEntities2();
        // GET: TablesEditable
        public ActionResult Index()
        {
            List<Patient_Info> infos = aDIYOS.Patient_Info.ToList();
            return View(infos);
        }
    }
}