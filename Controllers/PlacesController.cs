using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_project.Interfaces;
using web_project.Models;
using web_project.ViewModel;

namespace web_project.Controllers
{
    public class PlacesController : Controller
    {
        private readonly IAllPlaces _places;
        private readonly IPlacesCategory _categories;

        public PlacesController(IAllPlaces places, IPlacesCategory categories)
        {
            _places = places;
            _categories = categories;
        }

        public IActionResult List(int id)
        {
            if(id != 0)
            {

            }
            PlacesListViewModel placesList = new PlacesListViewModel();
            placesList.allPlaces = _places.Places;
            placesList.placeCategory = id.ToString();
            return View(placesList);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item(int id)
        {
            Place place = _places.getPlace(id); 
            return View(place);
        }

        public IActionResult Categories()
        {
            return View(_categories);
        }
    }
}