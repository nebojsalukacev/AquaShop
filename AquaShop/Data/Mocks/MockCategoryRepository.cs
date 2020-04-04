using AquaShop.Data.Interfaces;
using AquaShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquaShop.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetCategories()
        {
            List<Category> categoriesList = new List<Category>()
            {
                new Category{CategoryId=1, CategoryName="Aquarium"},
                new Category{CategoryId=2, CategoryName="Fish"},
                new Category{CategoryId=3, CategoryName="Plants"},
                new Category{CategoryId=4, CategoryName="Aquarium equipment"},
                new Category{CategoryId=5, CategoryName="Reef aquarium"}
            };
            return categoriesList;
        }
    }
}
