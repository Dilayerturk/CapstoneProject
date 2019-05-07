using refactoradiyos_final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace refactoradiyos_final.Views.KayitFormuEdit
{
    public class KayitFormuEditController : Controller
    {
        NewAdiyosEntities2 ADIYOSEntities1 = new NewAdiyosEntities2();


        public ActionResult Index(int pId)
        {
            GeneralModel generalModel = new GeneralModel();
            generalModel.patient_Info = ADIYOSEntities1.Patient_Info.Single(pat => pat.IDNo == pId);
            generalModel.bos = ADIYOSEntities1.BOS.Single(b => b.IDNo == pId);
            generalModel.c24 = ADIYOSEntities1.C24_Hour_Urine.Single(b => b.IDNo == pId);
            generalModel.biochemistry = ADIYOSEntities1.Biochemistry.Single(b => b.IDNo == pId);
            generalModel.cardiovascular_System = ADIYOSEntities1.Cardiovascular_System.Single(b => b.IDNo == pId);
            generalModel.clinic_Chemistry = ADIYOSEntities1.Clinic_Chemistry.Single(b => b.IDNo == pId);
            generalModel.coagulation = ADIYOSEntities1.Coagulation.Single(b => b.IDNo == pId);
            generalModel.complication = ADIYOSEntities1.Complications.Single(b => b.IDNo == pId);
            generalModel.consultation = ADIYOSEntities1.Consultation.Single(b => b.IDNo == pId);
            generalModel.decision_After_Evaluation = ADIYOSEntities1.Decision_After_Evaluation.Single(b => b.IDNo == pId);
            generalModel.diabetes_Education = ADIYOSEntities1.Diabetes_Education.Single(b => b.IDNo == pId);
            generalModel.diabetes_Info = ADIYOSEntities1.Diabetes_Info.Single(b => b.IDNo == pId);
            generalModel.drug_Layouts = ADIYOSEntities1.Drug_Layouts.Single(b => b.IDNo == pId);
            generalModel.endocrine = ADIYOSEntities1.Endocrine_System.Single(b => b.IDNo == pId);
            generalModel.habit = ADIYOSEntities1.Habits.Single(b => b.IDNo == pId);
            generalModel.hematoloji = ADIYOSEntities1.Hematoloji.Single(b => b.IDNo == pId);
            generalModel.hemoglobin = ADIYOSEntities1.Hemoglobin.Single(b => b.IDNo == pId);
            generalModel.history_Family = ADIYOSEntities1.History_Family.Single(b => b.IDNo == pId);
            generalModel.hormone = ADIYOSEntities1.Hormone.Single(b => b.IDNo == pId);
            generalModel.isletAntibody = ADIYOSEntities1.IsletAntibodies.Single(b => b.IDNo == pId);
            generalModel.medical_History = ADIYOSEntities1.Medical_History.Single(b => b.IDNo == pId);
            generalModel.medicine = ADIYOSEntities1.Medicine.Single(b => b.IDNo == pId);
            generalModel.medics_Used = ADIYOSEntities1.Medics_Used.Single(b => b.IDNo == pId);
            generalModel.neurological_System = ADIYOSEntities1.Neurological_System.Single(b => b.IDNo == pId);
            generalModel.obstetrik_History = ADIYOSEntities1.Obstetrik_History.Single(b => b.IDNo == pId);
            generalModel.other_Endocrine_System = ADIYOSEntities1.Other_Endocrine_System.Single(b => b.IDNo == pId);
            generalModel.other_Systems = ADIYOSEntities1.Other_Systems.Single(b => b.IDNo == pId);
            generalModel.physical_Examination = ADIYOSEntities1.Physical_Examination.Single(b => b.IDNo == pId);
            generalModel.tumor_Markers = ADIYOSEntities1.Tumor_Markers.Single(b => b.IDNo == pId);
            generalModel.urine = ADIYOSEntities1.Urine.Single(b => b.IDNo == pId);
            generalModel.urine_Spot = ADIYOSEntities1.Urine_Spot.Single(b => b.IDNo == pId);

            return View(generalModel);
        
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


            ADIYOSEntities1.Entry(pModel.patient_Info).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.bos).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.c24).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.cardiovascular_System).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.clinic_Chemistry).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.biochemistry).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.coagulation).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.complication).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.consultation).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.decision_After_Evaluation).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.diabetes_Education).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.diabetes_Info).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.drug_Layouts).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.endocrine).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.habit).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.hematoloji).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.hemoglobin).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.history_Family).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.hormone).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.isletAntibody).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.medical_History).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.medicine).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.medics_Used).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.neurological_System).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.obstetrik_History).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.other_Endocrine_System).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.other_Systems).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.physical_Examination).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.tumor_Markers).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.urine).State = System.Data.Entity.EntityState.Modified;
            ADIYOSEntities1.Entry(pModel.urine_Spot).State = System.Data.Entity.EntityState.Modified;


            
            ADIYOSEntities1.SaveChanges();
            return RedirectToAction("Index", "KayitFormuEdit" ,new { pId = pModel.patient_Info.IDNo });
        }
    }
}