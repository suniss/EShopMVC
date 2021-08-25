using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopMVC.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId= 1, CategoryName="Fruit pies", Description="All-FruitPie pie" },
                new Category{CategoryId= 2, CategoryName="Cheese cake", Description="Cheesy all the way" },
                new Category{CategoryId= 3, CategoryName="Seasonal Pie", Description="Get in The mood for a seasonal pie" }
                };
    }
}
