using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { get; set; }
        public List<Place> places { get; set; }
    }
}
