using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class Product
    {

        public int ProductID { get; set; }
        public string Nom { get; set; }
        public int Stocknb { get; set; }
        public string Picture { get; set; }
        public int Prix { get; set; }

        public Category Categories { get; set; }

        //[ForeignKey("CatId")]
        //public string CatId { get; set; }

        public virtual ICollection<ProductInCommand> ProductInCommands { get; set; }

        public virtual ICollection<ProductInCart> ProductInCarts { get; set; }

        public string Message { get; set; }

    }
}
