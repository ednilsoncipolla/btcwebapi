using btc.Data.Context;
using btc.Data.Repository;
using btc.Domain.Entiity;
using btcrio.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace btcrio.Data.Implementations
{
    public class RevendedorImplementation : BaseRepository<RevendedorEntity>, IRevendedorRepository
    {
        private DbSet<RevendedorEntity> _dataset;

        public RevendedorImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<RevendedorEntity>();
        }

        public async Task<RevendedorEntity> FindByLogin(string email)
        {
            return await _dataset.FirstOrDefaultAsync(r => r.Email.Equals(email));
        }
    }
}
