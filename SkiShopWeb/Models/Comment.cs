using System;
using System.Collections.Generic;

#nullable disable

namespace SkiShopWeb
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public string Message { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
