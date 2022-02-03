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
            if (ModelState.IsValid)
            {
                FilmsContext.Add(AF);
                FilmsContext.SaveChanges();
                return View("Index", AF);
            }
            else //if invalid
            {
                ViewBag.Categories = FilmsContext.Categories.ToList();

                return View(AF);
            }

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

        [HttpGet]
        public IActionResult Edit (int id )
        {
            ViewBag.Categories = FilmsContext.Categories.ToList();

            var film = FilmsContext.responses.Single(x => x.AppId == id);

            return View("AddFilm", film);
        }

        [HttpPost]
        public IActionResult Edit (AddFilmModel AF)
        {
            FilmsContext.Update(AF);
            FilmsContext.SaveChanges();

            return RedirectToAction("Collection");
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var film = FilmsContext.responses.Single(x => x.AppId == id);

            return View(film);
        }

        [HttpPost]
        public IActionResult Delete(AddFilmModel AF)
        {
            FilmsContext.responses.Remove(AF);
            FilmsContext.SaveChanges();
            return RedirectToAction("Collection");
        }

    }
}
