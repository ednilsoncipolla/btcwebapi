using btc.Domain.Entiity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace btc.Domain.Interfaces
{
    public interface IRevendedorService
    {
        Task<RevendedorEntity> Get(Guid id);
        Task<IEnumerable<RevendedorEntity>> GetAll();
        Task<RevendedorEntity> Post(RevendedorEntity entity);
        Task<RevendedorEntity> Put(RevendedorEntity entity);
        Task<bool> Delete(Guid id);

    }
}
