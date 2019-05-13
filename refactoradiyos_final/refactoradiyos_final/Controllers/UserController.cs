using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.DBModels;
using refactoradiyos_final.Models;


namespace refactoradiyos_final.Controllers
{
    public class UserController : Controller
    {
        SampleDBEntities4 objUserDbEntities4 = new SampleDBEntities4();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            UserModel objUserModel = new UserModel();
            return View(objUserModel);
        }

        [HttpPost]
        public ActionResult Register(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                if (objUserModel.Doctorepwd == objUserModel.Doctorpwd)
                {
                    Doctor_Info objUser = new DBModels.Doctor_Info();
                    objUser.DoctorName = objUserModel.DoctorName;
                    objUser.DoctorEmail = objUserModel.DoctorEmail;
                    objUser.Doctorpwd = objUserModel.Doctorpwd;
                    objUser.Doctorepwd = objUserModel.Doctorepwd;
                    objUser.Phone = objUserModel.Phone;
                    objUserDbEntities4.Doctor_Info.Add(objUser);
                    objUserDbEntities4.SaveChanges();
                    ViewData["Message"] = "Success";

                    return RedirectToAction("Index", "FirstPage");
                }
                else
                {
                    ViewData["Message2"] = "Lütfen paralolarınızı doğru girdiğinizden emin olun. ";
                }
            

            }
            return View();

        }

        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                if (objUserDbEntities4.Doctor_Info.Where(m => m.DoctorEmail == objLoginModel.DoctorEmail && m.Doctorpwd == objLoginModel.Doctorpwd).FirstOrDefault() == null)
                {
                    ModelState.AddModelError("Error","Email and Password is not matching");
                    return View();
                }
                else
                {
                    
                }
               
            }
            return RedirectToAction("Index", "FirstPage");
        }

        public ActionResult Logout()
        {
          
            Session.Abandon();
            return RedirectToAction("Login", "User");
        }

    
  
    }
}