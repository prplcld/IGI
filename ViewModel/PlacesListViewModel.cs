using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_project.Models;

namespace web_project.ViewModel
{
    public class PlacesListViewModel
    {
        public IEnumerable<Place> allPlaces { get; set; }

        public string placeCategory { get; set; }
    }
}
