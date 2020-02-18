using btc.Domain.Entiity;
using btcrio.Domain.Dtos;
using btcrio.Domain.Interfaces.Services.Revendedor;
using btcrio.Domain.Repository;
using btcrio.Domain.Securiy;
using Microsoft.Extensions.Configuration;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace btcrio.Service.Services
{
    public class LoginService : ILoginService
    {
        private IRevendedorRepository _repository;
        private SigningConfigurations _signingConfigurations;
        private TokenConfiguration _tokenConfiguration;
        private IConfiguration _configuratiom;
        public LoginService(
            IRevendedorRepository repository,
            SigningConfigurations signingConfigurations,
            TokenConfiguration tokenConfiguration,
            IConfiguration _configuratiom
            )
        {
            _repository = repository;

        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            var baseUser = new RevendedorEntity;
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email);
                if (baseUser == null)
                {
                    return new { authenticade = false, message = "Falha ao antenticar" };
                }
                else
                {
                    ClaimsIdentity identity = new ClaimsIdentity(
                        new GenericIdentity(baseUser.Email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
                        }
                    );

                    DateTime createDate = DateTime.Now;
                    DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfiguration.Seconds);

                }

                return await _repository.FindByLogin(user.Email);
            }
            else
            {
                return null;
            }
        }

    }
}

