using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class ProductInCart
    {
        public int ProductID { get; set; }
        public Product Products { get; set; }

        public int CartID { get; set; }
        public Cart Carts { get; set; }
    }
}
