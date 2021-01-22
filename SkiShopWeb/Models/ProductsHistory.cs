using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class ProductsHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Operation { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
