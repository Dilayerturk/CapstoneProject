using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace refactoradiyos_final.Controllers
{
    public class NewRegController : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(UserClass uc, HttpPostedFileBase file)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery =
                "insert into [dbo].[regUser](Uname,Uemail,Upwd,Gender,Uimg) values (@Uname,@Uemail,@Upwd,@Gender,@Uimg)";
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlconn.Open();
            sqlcomm.Parameters.AddWithValue("@Uname", uc.Uname);
            sqlcomm.Parameters.AddWithValue("@Uemail", uc.Uemail);
            sqlcomm.Parameters.AddWithValue("@Upwd", uc.Upwd);
            sqlcomm.Parameters.AddWithValue("@Gender", uc.Gender);

            if (file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/User-Images/"), fileName);
                file.SaveAs(imgpath);
            }

            sqlcomm.Parameters.AddWithValue("@Uimg", "~/User-Images/" + file.FileName);
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message"] = "User Record" + uc.Uname + "IS saved";
            return View();
        }
     
   
    }
}