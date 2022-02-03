using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mission4.Models;
//using DbContextOptionsBuilder.EnableSensitiveDataLogging;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private FilmsDBContext FilmsContext { get; set; }

        //Constructor

        public HomeController(FilmsDBContext someName)
        {
            FilmsContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            ViewBag.Categories = FilmsContext.Categories.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(AddFilmModel AF)
        {
            FilmsContext.Add(AF);
            FilmsContext.SaveChanges();
            return View("Index", AF);
        }

        [HttpGet]
        public IActionResult Collection ()
        {
            var filmData = FilmsContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(filmData);
        }

    }
}
