using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private MovieFormContext MaContext { get; set; }

        public HomeController(MovieFormContext someName)
        {
            MaContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories =  MaContext.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(FormResponse fr)
        {
            if (ModelState.IsValid)
            {
                MaContext.Add(fr);
                MaContext.SaveChanges();
                return RedirectToAction("MovieList");

            }
             else
            {
                ViewBag.Categories = MaContext.Categories.ToList();
                return View();
            }
        }
        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult MovieList ()
        {
            var movies = MaContext.Responses
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = MaContext.Categories.ToList();
            var movie = MaContext.Responses.Single(x => x.MovieId == movieid);
            return View("MovieForm", movie);
        }
        [HttpPost]
        public IActionResult Edit (FormResponse fr)
        {
                
                MaContext.Update(fr);
                MaContext.SaveChanges();
                return RedirectToAction("MovieList");
           
        }
        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var movie = MaContext.Responses.Single(x => x.MovieId == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete (FormResponse fr)
        {
            MaContext.Responses.Remove(fr);
            MaContext.SaveChanges();
            return RedirectToAction("MovieList");
            
        }
    }
}
