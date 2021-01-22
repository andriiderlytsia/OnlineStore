using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class ProductsOrder
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Quontity { get; set; }
        public decimal? OrderPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
