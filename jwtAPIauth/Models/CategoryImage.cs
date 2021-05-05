using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Models
{
    public class CategoryImage : FileUpload
    {
        public Category Category { get; set; }
        public long CategoryId { get; set; }
    }
}
