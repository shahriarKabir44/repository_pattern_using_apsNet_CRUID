using repository_pattern.Models;
using repository_pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace repository_pattern.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository stdRep = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            var x = stdRep.GetAll();
            return View(x);
        }
        [HttpGet]
        public ActionResult Details(int Id)
        {
            var x = stdRep.Get(Id);
            return View(x);
        }
    }
}