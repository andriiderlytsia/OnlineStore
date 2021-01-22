using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();
            ProductsOrders = new HashSet<ProductsOrder>();
            Ratings = new HashSet<Rating>();
        }

        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? Price { get; set; }
        public string ProductImg { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<ProductsOrder> ProductsOrders { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
