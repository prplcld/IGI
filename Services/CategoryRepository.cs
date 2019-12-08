using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_project.Interfaces;
using web_project.Models;

namespace web_project.Services
{
    public class CategoryRepository : IPlacesCategory
    {

        private readonly AppDbContext appDbContent;

        public CategoryRepository(AppDbContext appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
