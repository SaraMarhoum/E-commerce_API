using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class Category
    {
        public int CatID { get; set; }
        public string Nom { get; set; }
        public int CountProd { get; set; }
        public string Picture { get; set; }
    }
}
