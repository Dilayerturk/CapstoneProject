using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;
namespace refactoradiyos_final.Controllers
{
    public class KayitFormuController : Controller
    {

        NewAdiyosEntities2 ADIYOSEntities1 = new NewAdiyosEntities2();
        
        
      
        // GET: KayitFormu
        public ActionResult Index()
        {
            return View(new GeneralModel());
        }


        [HttpPost]
        public ActionResult create(GeneralModel pModel)
        {
            pModel.assignID();
            ADIYOSEntities1.Patient_Info.Add(pModel.patient_Info);
            ADIYOSEntities1.BOS.Add(pModel.bos);
            ADIYOSEntities1.C24_Hour_Urine.Add(pModel.c24);
            ADIYOSEntities1.Biochemistry.Add(pModel.biochemistry);
            ADIYOSEntities1.Cardiovascular_System.Add(pModel.cardiovascular_System);
            ADIYOSEntities1.Clinic_Chemistry.Add(pModel.clinic_Chemistry);
            ADIYOSEntities1.Coagulation.Add(pModel.coagulation);
            ADIYOSEntities1.Complications.Add(pModel.complication);
            ADIYOSEntities1.Consultation.Add(pModel.consultation);
            ADIYOSEntities1.Decision_After_Evaluation.Add(pModel.decision_After_Evaluation);
            ADIYOSEntities1.Diabetes_Education.Add(pModel.diabetes_Education);
            ADIYOSEntities1.Diabetes_Info.Add(pModel.diabetes_Info);
            ADIYOSEntities1.Drug_Layouts.Add(pModel.drug_Layouts);
            ADIYOSEntities1.Endocrine_System.Add(pModel.endocrine);
            ADIYOSEntities1.Habits.Add(pModel.habit);
            ADIYOSEntities1.Hematoloji.Add(pModel.hematoloji);
            ADIYOSEntities1.Hemoglobin.Add(pModel.hemoglobin);
            ADIYOSEntities1.History_Family.Add(pModel.history_Family);
            ADIYOSEntities1.Hormone.Add(pModel.hormone);
            ADIYOSEntities1.IsletAntibodies.Add(pModel.isletAntibody);
            ADIYOSEntities1.Medical_History.Add(pModel.medical_History);
            ADIYOSEntities1.Medicine.Add(pModel.medicine);
            ADIYOSEntities1.Medics_Used.Add(pModel.medics_Used);
            ADIYOSEntities1.Neurological_System.Add(pModel.neurological_System);
            ADIYOSEntities1.Obstetrik_History.Add(pModel.obstetrik_History);
            ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
            ADIYOSEntities1.Other_Systems.Add(pModel.other_Systems);
            ADIYOSEntities1.Physical_Examination.Add(pModel.physical_Examination);
            ADIYOSEntities1.Tumor_Markers.Add(pModel.tumor_Markers);
            ADIYOSEntities1.Urine.Add(pModel.urine);
            ADIYOSEntities1.Urine_Spot.Add(pModel.urine_Spot);
           
            ADIYOSEntities1.SaveChanges();
            return RedirectToAction("Index", "KayitFormu");
        }


    }
    
}