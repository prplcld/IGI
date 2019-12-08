using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_project.Models;

namespace web_project.Interfaces
{
    public interface IPlacesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
