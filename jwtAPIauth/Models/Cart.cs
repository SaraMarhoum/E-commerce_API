using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class Cart
    {
        public int CartID { get; set; }

        public int Count { get; set; }

        public ApplicationUser ApplicationUsers { get; set; }
        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<ProductInCart> ProductInCarts { get; set; }
    }
}
