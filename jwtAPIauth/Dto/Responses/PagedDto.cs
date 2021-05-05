using jwtAPIauth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Dto.Responses
{
    public class PagedDto : SuccessResponse
    {
        public PageMeta PageMeta { get; set; }
    }
   
}
