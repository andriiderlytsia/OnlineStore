using Microsoft.EntityFrameworkCore;
using SkiShopWeb.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiShopWeb.Data.Repository
{
    
    public class ProductRepository : IProduct
    {
        private readonly SkiShopContext Db;
        public ProductRepository(SkiShopContext skiShopContext)
        {
            this.Db = skiShopContext;
        }
        public IEnumerable<Product> GetProducts => Db.Products.Include(x => x.Category);

        public IEnumerable<Product> GetFavProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Product GetProductById(int carId) => Db.Products.Include(p => p.Brand).Include(c =>c.Comments).FirstOrDefault(p => p.ProductId == carId);
        
    }
}
