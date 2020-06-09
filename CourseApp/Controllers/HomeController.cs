using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Dijital Dönüşüm";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Details()
        {
            var firstmodel = new CourseModel();
            firstmodel.Name = "Asp.Net Core Eğitimi";
            firstmodel.Description = "Kaliteli Bir Eğitim Süreci";
            firstmodel.IsPublished = true;
            return View(firstmodel);
        }
    }
}