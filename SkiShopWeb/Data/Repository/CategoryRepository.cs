using SkiShopWeb.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopWeb.Data.Repository
{
    
    public class CategoryRepository : ICategory
    {
        private readonly SkiShopContext Db;
        public CategoryRepository(SkiShopContext skiShopContext)
        {
            this.Db = skiShopContext;
        }
        public IEnumerable<Category> GetCategories => Db.Categories;
    }
}
