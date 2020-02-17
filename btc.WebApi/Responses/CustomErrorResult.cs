using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace btc.WebApi.Responses
{
    public class CustomErrorResult : JsonResult
    {
        public CustomErrorResult(int statusCode, object value) : base(value)
        {
            StatusCode = statusCode;
        }
    }
}
