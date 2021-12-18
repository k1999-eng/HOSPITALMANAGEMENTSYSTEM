using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HOSPITALMANAGEMENTSYSTEM.Models;
using System.Data;

namespace HOSPITALMANAGEMENTSYSTEM.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        // GET: Admin
        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult AddPatient()
        {
            return View();
        }
        public ActionResult AddDoctor()
        {
            return View();
        }


        public ActionResult AdminHome()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AddSpecialization()
        {
            return View();
        }
    }
}