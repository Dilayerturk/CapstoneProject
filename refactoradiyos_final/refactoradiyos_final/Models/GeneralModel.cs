using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace refactoradiyos_final.Models
{
    public class GeneralModel
    {
        
        public Biochemistry biochemistry { get; set; }
        public BOS bos { get; set; }
        public C24_Hour_Urine c24 { get; set;}
        public Cardiovascular_System cardiovascular_System { get; set; }
        public Clinic_Chemistry clinic_Chemistry { get; set; }
        public Coagulation coagulation { get; set;}
        public Complications complication { get; set; }
        public Consultation consultation { get; set; }
        public Decision_After_Evaluation decision_After_Evaluation { get; set; }
        public Diabetes_Education diabetes_Education { get; set; }
        public Diabetes_Info diabetes_Info { get; set; }
        public Drug_Layouts drug_Layouts { get; set; }
        public Endocrine_System endocrine { get; set; }
        public Habits habit { get; set; }
        public Hematoloji hematoloji { get; set; }
        public Hemoglobin hemoglobin { get; set; }
        public History_Family history_Family { get; set; }
        public Hormone hormone { get; set; }
        public IsletAntibodies isletAntibody { get; set; }
        public Medical_History medical_History { get; set; }
        public Medicine medicine { get; set; }
        public Medics_Used medics_Used { get; set; }
        public Neurological_System neurological_System { get; set; }
        public Obstetrik_History obstetrik_History { get; set; }
        public Other_Endocrine_System other_Endocrine_System { get; set; }
        public Other_Systems other_Systems { get; set; }

        public Patient_Info patient_Info { get; set; }
        public Physical_Examination physical_Examination { get; set; }
        public Tumor_Markers tumor_Markers { get; set; }
        public Urine urine { get; set; }
        public Urine_Spot urine_Spot { get; set; }

        public void assignID()
        {
            this.urine_Spot.IDNo = this.patient_Info.IDNo;
            this.urine.IDNo = this.patient_Info.IDNo;
            this.tumor_Markers.IDNo = this.patient_Info.IDNo;
            this.physical_Examination.IDNo = this.patient_Info.IDNo;
            this.other_Systems.IDNo = this.patient_Info.IDNo;
            this.other_Endocrine_System.IDNo = this.patient_Info.IDNo;
            this.obstetrik_History.IDNo = this.patient_Info.IDNo;
            this.neurological_System.IDNo = this.patient_Info.IDNo;
            this.medics_Used.IDNo = this.patient_Info.IDNo;
            this.medicine.IDNo = this.patient_Info.IDNo;
            this.medical_History.IDNo = this.patient_Info.IDNo;
            this.isletAntibody.IDNo = this.patient_Info.IDNo;
            this.hormone.IDNo = this.patient_Info.IDNo;
            this.history_Family.IDNo = this.patient_Info.IDNo;
            this.hemoglobin.IDNo = this.patient_Info.IDNo;
            this.hematoloji.IDNo = this.patient_Info.IDNo;
            this.habit.IDNo = this.patient_Info.IDNo;
            this.endocrine.IDNo = this.patient_Info.IDNo;
            this.drug_Layouts.IDNo = this.patient_Info.IDNo;
            this.diabetes_Info.IDNo = this.patient_Info.IDNo;
            this.diabetes_Education.IDNo = this.patient_Info.IDNo;
            this.decision_After_Evaluation.IDNo = this.patient_Info.IDNo;
            this.consultation.IDNo = this.patient_Info.IDNo;
            this.complication.IDNo = this.patient_Info.IDNo;
            this.coagulation.IDNo = this.patient_Info.IDNo;
            this.clinic_Chemistry.IDNo = this.patient_Info.IDNo;
            this.cardiovascular_System.IDNo = this.patient_Info.IDNo;
            this.c24.IDNo = this.patient_Info.IDNo;
            this.bos.IDNo = this.patient_Info.IDNo;
            this.biochemistry.IDNo = this.patient_Info.IDNo;

        }


        public GeneralModel()
        {
            this.decision_After_Evaluation = new Decision_After_Evaluation();
           // this.patient_Info = new Patient_Info();
            this.habit = new Habits();
            this.hematoloji = new Hematoloji();
            this.history_Family = new History_Family();
            this.hormone = new Hormone();
            this.biochemistry = new Biochemistry();
            this.bos = new BOS();
            this.c24 = new C24_Hour_Urine();
            this.cardiovascular_System = new Cardiovascular_System();
            this.clinic_Chemistry = new Clinic_Chemistry();
            this.coagulation = new Coagulation();
            this.complication = new Complications();
            this.consultation = new Consultation();
            this.diabetes_Education = new Diabetes_Education();
            this.diabetes_Info = new Diabetes_Info();
            this.drug_Layouts = new Drug_Layouts();
            this.endocrine = new Endocrine_System();
            this.hemoglobin = new Hemoglobin();
            this.isletAntibody = new IsletAntibodies();
            this.medical_History = new Medical_History();
            this.medicine = new Medicine();
            this.medics_Used = new Medics_Used();
            this.neurological_System = new Neurological_System();
            this.obstetrik_History = new Obstetrik_History();
            this.other_Endocrine_System = new Other_Endocrine_System();
            this.other_Systems = new Other_Systems();
            this.physical_Examination = new Physical_Examination();
            this.tumor_Markers = new Tumor_Markers();
            this.urine = new Urine();
            this.urine_Spot = new Urine_Spot();
            



       

          

        }

    }
}