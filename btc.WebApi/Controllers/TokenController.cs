using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using btc.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using WebApi.Responses;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public TokenController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RequestToken([FromBody] Usuario request)
        {
            try
            {
                if (request.login == "edy" && request.Senha == "abc=123")
                {
                    var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration["SecurityKey"])
                        );

                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    var token = new JwtSecurityToken(
                        issuer: "btc.net",
                        audience: "btc.net",
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: creds
                        );

                    return Ok(
                        new
                        {
                            token = new JwtSecurityTokenHandler().WriteToken(token)
                        });
                }
                else
                {
                    return BadRequest("Credenciais inválidas");
                }
            }
            catch (Exception ex)
            {
                return new CustomErrorResult(500, new ErrorMessages("Ocorreu um erro ao gerar o token.\n" +
                    ex.Message));
            }
        }
    }
}