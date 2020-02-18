using btc.Domain.Entiity;
using btcrio.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace btcrio.Domain.Interfaces.Services.Revendedor
{
    public interface ILoginService
    {
        Task<object> FindByLogin(LoginDto login);
    }
}
