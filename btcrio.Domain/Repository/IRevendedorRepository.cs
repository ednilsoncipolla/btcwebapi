using btc.Domain.Entiity;
using btc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace btcrio.Domain.Repository
{
    public interface IRevendedorRepository : IRepository<RevendedorEntity>
    {
        Task<RevendedorEntity> FindByLogin(string email);
    }
}
