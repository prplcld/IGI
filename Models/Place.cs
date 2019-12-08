using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_project.Models
{
    public class Place
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDescription { get; set; }
        public string longDescription { get; set; }
        public string img { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
