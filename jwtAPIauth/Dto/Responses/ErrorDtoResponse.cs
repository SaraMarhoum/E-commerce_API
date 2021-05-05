using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwtAPIauth.Dto.Responses
{
    public class ErrorDtoResponse : AppResponse
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public ErrorDtoResponse() : base(false)
        {
        }

        public ErrorDtoResponse(string message) : base(false, message)
        {
        }
    }
}
