using Newtonsoft.Json;
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
        public Object Details(int Id)
        {
            var x = stdRep.Get(Id);
            return Json(x, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public Object Getstds()
        {
            var x = new List<Student>() {
                new Student(){Name="aa",ID=1},
                new Student(){Name="aac",ID=3}
            };
            var y = stdRep.GetAll();
            
            return Json(y,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public bool UpdateStudent(Student std)
        {
            try
            {
                    stdRep.Update(std);
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}