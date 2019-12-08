using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_project.Interfaces;
using web_project.Models;

namespace web_project.Services
{
    public class PlacesRepository : IAllPlaces
    {

        private readonly AppDbContext appDbContent;

        public PlacesRepository(AppDbContext appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Place> Places { get => appDbContent.Place.Include(p => p.Category); set => throw new NotImplementedException(); }

        public Place getPlace(int placeId) => appDbContent.Place.FirstOrDefault(p => p.id == placeId);
       
    }
}
