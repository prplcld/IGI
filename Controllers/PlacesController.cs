using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_project.Models;
using web_project.Services;
using web_project.ViewModel;

namespace web_project.Controllers
{
    public class PlacesController : Controller
    {

        private AppDbContext appDbContext;

        public PlacesController(AppDbContext context)
        {
            appDbContext = context;
        }

        public IActionResult List(int id)
        {
            if(id == 0)
            {
                return View(appDbContext.Place);
            }
            else
            {
                return View(appDbContext.Place.Where(p => p.CategoryId == id));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item(int id)
        {
            Place place = appDbContext.Place.Find(id);
            return View(place);
        }

        public IActionResult Categories()
        {
            return View(appDbContext.Category);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Place place)
        {
            appDbContext.Place.Add(place);
            appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            if(id == 0)
            {
                return RedirectToAction("Index");
            }
            Place place = appDbContext.Place.Find(id);
            if(place != null)
            {
                return View(place);
            }
            return RedirectToAction("Index");
        }


    }
}