using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using refactoradiyos_final.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace refactoradiyos_final.Controllers
{
    public class DoctorAccountController : Controller
    {
        // GET: DoctorAccount
        NewAdiyosEntities2 db = new NewAdiyosEntities2();

     
        public ActionResult Register()
        {
            return View(new AccountDBContext());
        }

        [HttpPost]
        public ActionResult Register(Doctor_Account account)
        {
            if (ModelState.IsValid)
            {
                {
                    
                    db.Doctor_Account.Add(account);
                    db.SaveChanges();
                    return RedirectToAction("LoggedIn");
                }
            }

            return View();
        }

        //Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Doctor_Account account)
        {
            if (ModelState.IsValid)
            {
                var user =  db.Doctor_Account.Single(u => u.DoctorID == account.DoctorID && u.Password == account.Password);
                if (user != null)
                {
                    Session["UserID"] = user.DoctorID.ToString();
                    Session["Name"] = user.Name.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong");
                }
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if (Session["DoctorID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

       
    }
}