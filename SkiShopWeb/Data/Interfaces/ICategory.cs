using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopWeb.Data.Interfaces
{
    public interface ICategory
    {
        public IEnumerable<Category> GetCategories { get; }
    }
}
