using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApi.Responses;

namespace WebApi.Controllers
{
    internal class CustomErrorResult : IActionResult
    {
        private int v;
        private ErrorMessages errorMessages;

        public CustomErrorResult(int v, ErrorMessages errorMessages)
        {
            this.v = v;
            this.errorMessages = errorMessages;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
           await new Task(() =>
           {
               this.v = v;
               this.errorMessages = errorMessages;
           });
        }
    }
}