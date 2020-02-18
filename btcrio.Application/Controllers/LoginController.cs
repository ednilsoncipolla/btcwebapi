using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using btc.Domain.Entiity;
using btcrio.Domain.Dtos;
using btcrio.Domain.Interfaces.Services.Revendedor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace btcrio.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController()
        {

        }

        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto login, [FromServices]ILoginService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await service.FindByLogin(login);

                if (result == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(result);
                }

            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}