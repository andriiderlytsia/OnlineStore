using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class Order
    {
        public Order()
        {
            ProductsOrders = new HashSet<ProductsOrder>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? Date { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ProductsOrder> ProductsOrders { get; set; }
    }
}
