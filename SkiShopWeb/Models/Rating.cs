using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class Rating
    {
        public int RatingId { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? Stars { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
