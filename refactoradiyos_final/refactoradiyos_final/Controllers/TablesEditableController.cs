using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;

namespace refactoradiyos_final.Controllers
{
    public class TablesEditableController : Controller
    {
        dbadiyoscapstoneEntities ADIYOSEntities1 = new dbadiyoscapstoneEntities();
        // GET: TablesEditable
        public ActionResult Index()
        {
            List<Patient_Info> infos = ADIYOSEntities1.Patient_Info.ToList();
            return View(infos);
        }

        public ActionResult Delete(int pId)
        {

            GeneralModel generalModel = new GeneralModel();
            generalModel.patient_Info = ADIYOSEntities1.Patient_Info.Single(pat => pat.ID == pId);
            generalModel.bos = ADIYOSEntities1.BOS.Single(b => b.ID == pId);
            generalModel.c24 = ADIYOSEntities1.C24_Hour_Urine.Single(b => b.ID == pId);
            generalModel.biochemistry = ADIYOSEntities1.Biochemistry.Single(b => b.ID == pId);
            generalModel.cardiovascular_System = ADIYOSEntities1.Cardiovascular_System.Single(b => b.ID == pId);
            generalModel.clinic_Chemistry = ADIYOSEntities1.Clinic_Chemistry.Single(b => b.ID == pId);
            generalModel.coagulation = ADIYOSEntities1.Coagulation.Single(b => b.ID == pId);
            generalModel.complication = ADIYOSEntities1.Complications.Single(b => b.ID == pId);
            generalModel.consultation = ADIYOSEntities1.Consultation.Single(b => b.ID == pId);
            generalModel.decision_After_Evaluation = ADIYOSEntities1.Decision_After_Evaluation.Single(b => b.ID == pId);
            generalModel.diabetes_Education = ADIYOSEntities1.Diabetes_Education.Single(b => b.ID == pId);
            generalModel.diabetes_Info = ADIYOSEntities1.Diabetes_Info.Single(b => b.ID == pId);
            generalModel.drug_Layouts = ADIYOSEntities1.Drug_Layouts.Single(b => b.ID == pId);
            generalModel.endocrine = ADIYOSEntities1.Endocrine_System.Single(b => b.ID == pId);
            generalModel.habit = ADIYOSEntities1.Habits.Single(b => b.ID == pId);
            generalModel.hematoloji = ADIYOSEntities1.Hematoloji.Single(b => b.ID == pId);
            generalModel.hemoglobin = ADIYOSEntities1.Hemoglobin.Single(b => b.ID == pId);
            generalModel.history_Family = ADIYOSEntities1.History_Family.Single(b => b.ID == pId);
            generalModel.hormone = ADIYOSEntities1.Hormone.Single(b => b.ID == pId);
            generalModel.isletAntibody = ADIYOSEntities1.IsletAntibodies.Single(b => b.ID == pId);
            generalModel.medical_History = ADIYOSEntities1.Medical_History.Single(b => b.ID == pId);
            generalModel.medicine = ADIYOSEntities1.Medicine.Single(b => b.ID == pId);
            generalModel.medics_Used = ADIYOSEntities1.Medics_Used.Single(b => b.ID == pId);
            generalModel.neurological_System = ADIYOSEntities1.Neurological_System.Single(b => b.ID == pId);
            generalModel.obstetrik_History = ADIYOSEntities1.Obstetrik_History.Single(b => b.ID == pId);
            generalModel.other_Endocrine_System = ADIYOSEntities1.Other_Endocrine_System.Single(b => b.ID == pId);
            generalModel.other_Systems = ADIYOSEntities1.Other_Systems.Single(b => b.ID == pId);
            generalModel.physical_Examination = ADIYOSEntities1.Physical_Examination.Single(b => b.ID == pId);
            generalModel.tumor_Markers = ADIYOSEntities1.Tumor_Markers.Single(b => b.ID == pId);
            generalModel.urine = ADIYOSEntities1.Urine.Single(b => b.ID == pId);
            generalModel.urine_Spot = ADIYOSEntities1.Urine_Spot.Single(b => b.ID == pId);

            ADIYOSEntities1.Patient_Info.Remove(generalModel.patient_Info);
            ADIYOSEntities1.BOS.Remove(generalModel.bos);
            ADIYOSEntities1.C24_Hour_Urine.Remove(generalModel.c24);
            ADIYOSEntities1.Biochemistry.Remove(generalModel.biochemistry);
            ADIYOSEntities1.Cardiovascular_System.Remove(generalModel.cardiovascular_System);
            ADIYOSEntities1.Clinic_Chemistry.Remove(generalModel.clinic_Chemistry);
            ADIYOSEntities1.Coagulation.Remove(generalModel.coagulation);
            ADIYOSEntities1.Complications.Remove(generalModel.complication);
            ADIYOSEntities1.Consultation.Remove(generalModel.consultation);
            ADIYOSEntities1.Decision_After_Evaluation.Remove(generalModel.decision_After_Evaluation);
            ADIYOSEntities1.Diabetes_Education.Remove(generalModel.diabetes_Education);
            ADIYOSEntities1.Diabetes_Info.Remove(generalModel.diabetes_Info);
            ADIYOSEntities1.Drug_Layouts.Remove(generalModel.drug_Layouts);
            ADIYOSEntities1.Endocrine_System.Remove(generalModel.endocrine);
            ADIYOSEntities1.Habits.Remove(generalModel.habit);
            ADIYOSEntities1.Hematoloji.Remove(generalModel.hematoloji);
            ADIYOSEntities1.Hemoglobin.Remove(generalModel.hemoglobin);
            ADIYOSEntities1.History_Family.Remove(generalModel.history_Family);
            ADIYOSEntities1.Hormone.Remove(generalModel.hormone);
            ADIYOSEntities1.IsletAntibodies.Remove(generalModel.isletAntibody);
            ADIYOSEntities1.Medical_History.Remove(generalModel.medical_History);
            ADIYOSEntities1.Medicine.Remove(generalModel.medicine);
            ADIYOSEntities1.Medics_Used.Remove(generalModel.medics_Used);
            ADIYOSEntities1.Neurological_System.Remove(generalModel.neurological_System);
            ADIYOSEntities1.Obstetrik_History.Remove(generalModel.obstetrik_History);
            ADIYOSEntities1.Other_Endocrine_System.Remove(generalModel.other_Endocrine_System);
            ADIYOSEntities1.Other_Systems.Remove(generalModel.other_Systems);
            ADIYOSEntities1.Physical_Examination.Remove(generalModel.physical_Examination);
            ADIYOSEntities1.Tumor_Markers.Remove(generalModel.tumor_Markers);
            ADIYOSEntities1.Urine.Remove(generalModel.urine);
            ADIYOSEntities1.Urine_Spot.Remove(generalModel.urine_Spot);

            ADIYOSEntities1.Entry(generalModel.patient_Info).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.bos).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.c24).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.cardiovascular_System).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.clinic_Chemistry).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.biochemistry).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.coagulation).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.complication).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.consultation).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.decision_After_Evaluation).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.diabetes_Education).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.diabetes_Info).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.drug_Layouts).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.endocrine).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.habit).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.hematoloji).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.hemoglobin).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.history_Family).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.hormone).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.isletAntibody).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.medical_History).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.medicine).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.medics_Used).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.neurological_System).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.obstetrik_History).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.other_Endocrine_System).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.other_Systems).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.physical_Examination).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.tumor_Markers).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.urine).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.Entry(generalModel.urine_Spot).State = System.Data.Entity.EntityState.Deleted;
            ADIYOSEntities1.SaveChanges();





            return RedirectToAction("Index", "TablesEditable");
        }
    }
}