using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor;
using System.Web.Security.AntiXss;
using refactoradiyos_final.Models;
namespace refactoradiyos_final.Controllers
{
    public class KayitFormuController : Controller
    {

        dbadiyoscapstoneEntities ADIYOSEntities1 = new dbadiyoscapstoneEntities();
        
        
      
        // GET: KayitFormu
        public ActionResult Index()
        {
            GeneralModel pModel2 = TempData["Data"] as GeneralModel;
            if (pModel2 == null)
            {
                return View(new GeneralModel());
            }
            else
            {
                ViewData["Message"] = "TC Kimlik Numarasını 11 haneli girin";
               

                return View(pModel2);
            }
            
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
                HttpPostedFileBase ekg = Request.Files["EKGFile"];


                    string fileName = Path.GetFileNameWithoutExtension(ekg.FileName);
                    string extension = Path.GetExtension(ekg.FileName);
                    pModel.other_Endocrine_System.EKG = "~/Patient-Images/" + fileName + extension;
                    fileName = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName + extension);
                    ekg.SaveAs(fileName);
                    ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                    ADIYOSEntities1.Entry(pModel.other_Endocrine_System).State = System.Data.Entity.EntityState.Modified;
           

                HttpPostedFileBase eko = Request.Files["EKOFile"];

              
                    string fileName2 = Path.GetFileNameWithoutExtension(eko.FileName);
                    string extension2 = Path.GetExtension(eko.FileName);
                    pModel.other_Endocrine_System.EKO = "~/Patient-Images/" + fileName2 + extension2;
                    fileName2 = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName2 + extension2);
                    eko.SaveAs(fileName2);
                    ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                    ADIYOSEntities1.Entry(pModel.other_Endocrine_System).State = System.Data.Entity.EntityState.Modified;
             

                HttpPostedFileBase eGFR = Request.Files["eGFRFile"];

                    string fileName3 = Path.GetFileNameWithoutExtension(eGFR.FileName);
                    string extension3 = Path.GetExtension(eGFR.FileName);
                    pModel.other_Endocrine_System.eGFR = "~/Patient-Images/" + fileName3 + extension3;
                    fileName3 = Path.Combine(Server.MapPath("~/Patient-Images/"), fileName3 + extension3);
                    eGFR.SaveAs(fileName3);
                    ADIYOSEntities1.Other_Endocrine_System.Add(pModel.other_Endocrine_System);
                    ADIYOSEntities1.Entry(pModel.other_Endocrine_System).State = System.Data.Entity.EntityState.Modified;
            
    */



                try
                {
                    ADIYOSEntities1.SaveChanges();
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }
             
                return RedirectToAction("Index", "TablesEditable");
          
            }
            else
            {
                TempData["Data"] = pModel;
                return RedirectToAction("Index","KayitFormu");
            }
           
        }
       

    }
    
}