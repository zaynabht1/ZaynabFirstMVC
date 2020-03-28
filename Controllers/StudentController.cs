using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZaynabFirstMVC.Models;

namespace ZaynabFirstMVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStudentName()
        {
            Student s = new Student();
            s.StudentName = "Zaynab";
            return View(s);
        }


    }
}