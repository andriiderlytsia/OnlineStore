using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopWeb.Data.Interfaces
{
    public interface IProduct
    {
        public IEnumerable<Product> GetProducts { get; }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetProductById(int carId);
    }
}
