﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace refactoradiyos_final
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewAdiyosEntities2 : DbContext
    {
        public NewAdiyosEntities2()
            : base("name=NewAdiyosEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C24_Hour_Urine> C24_Hour_Urine { get; set; }
        public virtual DbSet<Biochemistry> Biochemistry { get; set; }
        public virtual DbSet<BOS> BOS { get; set; }
        public virtual DbSet<Cardiovascular_System> Cardiovascular_System { get; set; }
        public virtual DbSet<Clinic_Chemistry> Clinic_Chemistry { get; set; }
        public virtual DbSet<Coagulation> Coagulation { get; set; }
        public virtual DbSet<Complications> Complications { get; set; }
        public virtual DbSet<Consultation> Consultation { get; set; }
        public virtual DbSet<Decision_After_Evaluation> Decision_After_Evaluation { get; set; }
        public virtual DbSet<Diabetes_Education> Diabetes_Education { get; set; }
        public virtual DbSet<Diabetes_Info> Diabetes_Info { get; set; }
        public virtual DbSet<Doctor_Account> Doctor_Account { get; set; }
        public virtual DbSet<Drug_Layouts> Drug_Layouts { get; set; }
        public virtual DbSet<Endocrine_System> Endocrine_System { get; set; }
        public virtual DbSet<Habits> Habits { get; set; }
        public virtual DbSet<Hematoloji> Hematoloji { get; set; }
        public virtual DbSet<Hemoglobin> Hemoglobin { get; set; }
        public virtual DbSet<History_Family> History_Family { get; set; }
        public virtual DbSet<Hormone> Hormone { get; set; }
        public virtual DbSet<IsletAntibodies> IsletAntibodies { get; set; }
        public virtual DbSet<Medical_History> Medical_History { get; set; }
        public virtual DbSet<Medicine> Medicine { get; set; }
        public virtual DbSet<Medics_Used> Medics_Used { get; set; }
        public virtual DbSet<Neurological_System> Neurological_System { get; set; }
        public virtual DbSet<Obstetrik_History> Obstetrik_History { get; set; }
        public virtual DbSet<Other_Endocrine_System> Other_Endocrine_System { get; set; }
        public virtual DbSet<Other_Systems> Other_Systems { get; set; }
        public virtual DbSet<Patient_Info> Patient_Info { get; set; }
        public virtual DbSet<Physical_Examination> Physical_Examination { get; set; }
        public virtual DbSet<Tumor_Markers> Tumor_Markers { get; set; }
        public virtual DbSet<Urine> Urine { get; set; }
        public virtual DbSet<Urine_Spot> Urine_Spot { get; set; }
        public virtual DbSet<Doctor_Avatar> Doctor_Avatar { get; set; }
    }
}
