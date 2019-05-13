using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;
using System.Data;
using Microsoft.AspNet.Identity;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace refactoradiyos_final.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(UserModel model, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery =
                    "insert into [dbo].[Doctor_Info](DoctorName,DoctorEmail,Phone,Doctorpwd,Doctorepwd) values (@DoctorName,@DoctorEmail,@Phone,@Doctorpwd,@Doctorepwd)";
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                if (model.Doctorpwd == model.Doctorepwd)
                {
                    sqlconn.Open();
                    sqlcomm.Parameters.AddWithValue("@DoctorName", model.DoctorName);
                    sqlcomm.Parameters.AddWithValue("@DoctorEmail", model.DoctorEmail);
                    sqlcomm.Parameters.AddWithValue("@Phone", model.Phone);
                    sqlcomm.Parameters.AddWithValue("@Doctorpwd", model.Doctorpwd);
                    sqlcomm.Parameters.AddWithValue("@Doctorepwd", model.Doctorepwd);

                    sqlcomm.ExecuteNonQuery();
                    sqlconn.Close();
                    ViewData["Message"] = "Kullanıcı " + model.DoctorName + " adı ile sisteme kayıt oldu.";
                }
                else
                {
                    ViewData["Message"] = "Parolalar eşleşmiyor.";
                }

            }
            return View(model);
        }


        [AllowAnonymous]
        public ActionResult Login()
        {


            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {

                string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                SqlCommand com = new SqlCommand("CUser", sqlconn);
                com.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter p1 = new SqlParameter("@DoctorEmail", model.DoctorEmail);
                SqlParameter p2 = new SqlParameter("@Doctorpwd", model.Doctorpwd);
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                sqlconn.Open();
                SqlDataReader rd = com.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    ViewData["Message"] = "Kullanıcı " + model.DoctorName + " adı ile sistemde kayıtlı";
                }
                else
                {
                    ViewData["Message"] = "Kullanıcı Sistemde bulunamadı";
                }



            }
            return View(model);
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}