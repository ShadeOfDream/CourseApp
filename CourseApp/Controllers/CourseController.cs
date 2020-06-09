using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var liste = Repository.Students.Where(i => i.Confirm == true);
            return View(liste);
            
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(StudentModel student)
        {
            if (ModelState.IsValid) 
            {
                Repository.AddStudent(student);
                return View("Kaydedildi", student); 
            }
            else
            {
                return View(student);
            }
        }

        public IActionResult Kaydedildi()
        {
            return View();
        }
    }
}