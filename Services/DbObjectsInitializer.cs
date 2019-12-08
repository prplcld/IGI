using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_project.Models;

namespace web_project.Services
{
    public class DbObjectsInitializer
    {
        public static void Init(AppDbContext content)
        {
            var rows = from o in content.Place select o;
            foreach(var row in rows)
            {
                content.Place.Remove(row);
            }
       
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            
            content.Place.AddRange(
                new Place { name = "South Korea", shortDescription = "", longDescription = "", img = "/img/team1.png", Category = Categories["Asia"] },
                new Place { name = "China", shortDescription = "", longDescription = "", img = "/img/team2.png", Category = Categories["Asia"] },
                new Place { name = "Japan", shortDescription = "", longDescription = "", img = "https://st.depositphotos.com/1035350/2894/i/450/depositphotos_28948583-stock-photo-mt-fujiin-autumn.jpg", Category = Categories["Asia"] },
                new Place { name = "Thailand", shortDescription = "", longDescription = "", img = "/img/team1.png", Category = Categories["Asia"] }
                );

            

            content.SaveChanges();
        }
   

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Europe", description = "Раздел Европа"},
                        new Category { categoryName = "Asia", description = "Раздел Азия"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach(Category c in list)
                    {
                        category.Add(c.categoryName, c);
                    }
                }
                return category;
            }
        }
    }
}
