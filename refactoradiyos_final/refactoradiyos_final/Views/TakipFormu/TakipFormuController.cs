using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;
using System.IO;

namespace refactoradiyos_final.Views.TakipFormu
{
    public class TakipFormuController : Controller
    {
        dbadiyoscapstoneEntities ADIYOSEntities1 = new dbadiyoscapstoneEntities();
        // GET: Takip
        public ActionResult Index(long pId)
        {
         
            GeneralModel generalModel = new GeneralModel();
        
            generalModel.patient_Info = ADIYOSEntities1.Patient_Info.Single(pat => pat.ID == pId);
            generalModel.diabetes_Education = ADIYOSEntities1.Diabetes_Education.Single(b => b.ID == pId);
            generalModel.diabetes_Info = ADIYOSEntities1.Diabetes_Info.Single(b => b.ID == pId);
            generalModel.habit = ADIYOSEntities1.Habits.Single(b => b.ID == pId);
            generalModel.history_Family = ADIYOSEntities1.History_Family.Single(b => b.ID == pId);
            generalModel.isletAntibody = ADIYOSEntities1.IsletAntibodies.Single(b => b.ID == pId);
            generalModel.medical_History = ADIYOSEntities1.Medical_History.Single(b => b.ID == pId);
            generalModel.medicine = ADIYOSEntities1.Medicine.Single(b => b.ID == pId);
            generalModel.medics_Used = ADIYOSEntities1.Medics_Used.Single(b => b.ID == pId);
            generalModel.obstetrik_History = ADIYOSEntities1.Obstetrik_History.Single(b => b.ID == pId);

            return View(generalModel);
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult create()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult create(GeneralModel pModel)
        {

            if (ModelState.IsValid)
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

                /*
                HttpPostedFileBase ekg2 = Request.Files["EKGFile2"];


                if (ekg2 != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(ekg2.FileName);
                    string extension = Path.GetExtension(ekg2.FileName);
                    pModel.other_Endocrine_System.EKG = "~/Patient-Images/" + fileName + extension;
                    fileName = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName + extension);
                    ekg2.SaveAs(fileName); ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                }

                HttpPostedFileBase eko2 = Request.Files["EKOFile2"];


                if (eko2 != null)
                {
                    string fileName2 = Path.GetFileNameWithoutExtension(eko2.FileName);
                    string extension2 = Path.GetExtension(eko2.FileName);
                    pModel.other_Endocrine_System.EKO = "~/Patient-Images/" + fileName2 + extension2;
                    fileName2 = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName2 + extension2);
                    eko2.SaveAs(fileName2);
                    ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                }

                HttpPostedFileBase eGFR2 = Request.Files["eGFRFile2"];


                if (eGFR2 != null)
                {
                    string fileName3 = Path.GetFileNameWithoutExtension(eGFR2.FileName);
                    string extension3 = Path.GetExtension(eGFR2.FileName);
                    pModel.other_Endocrine_System.eGFR = "~/Patient-Images/" + fileName3 + extension3;
                    fileName3 = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName3 + extension3);
                    eGFR2.SaveAs(fileName3);
                    ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                }

               */

                ADIYOSEntities1.SaveChanges();

                return RedirectToAction("Index", "TakipFormu", new { pId = pModel.patient_Info.ID });
            }
            else
            {
                return RedirectToAction("Index", "TakipFormu");
            }

        }
    }
}