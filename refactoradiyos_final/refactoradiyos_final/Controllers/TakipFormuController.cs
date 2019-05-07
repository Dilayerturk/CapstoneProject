using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;

namespace refactoradiyos_final.Controllers
{
    public class TakipFormuController : Controller
    {
        // GET: TakipFormu
        public ActionResult Index(int pId)
        {
            NewAdiyosEntities2 aDIYOSEntities5 = new NewAdiyosEntities2();
            GeneralModel generalModel = new GeneralModel();
            Patient_Info patient_Info = aDIYOSEntities5.Patient_Info.Single(pat => pat.IDNo == pId);
            generalModel.patient_Info = patient_Info;
            return View(generalModel);
        }
      
    }
}