using btc.Domain.Entiity;
using btc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace btc.Service.Revendedor
{
    public class RevendedorService : IRevendedorService
    {
        private IRepository<RevendedorEntity> _repository;

        public RevendedorService(IRepository<RevendedorEntity> repository)
        {
            _repository = repository;
        }
 
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<RevendedorEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<RevendedorEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<RevendedorEntity> Post(RevendedorEntity entity)
        {
            if (
                string.IsNullOrWhiteSpace(entity.NomeCompleto)
                || string.IsNullOrWhiteSpace(entity.CPF)
                || string.IsNullOrWhiteSpace(entity.Email)
                || string.IsNullOrWhiteSpace(entity.Senha)
                )
            {
                throw new ArgumentException("É obrigatório informar o Nome completo, o CPF, o email e a senha!");
            }

            return await _repository.InsertAsync(entity);
        }

        public async Task<RevendedorEntity> Put(RevendedorEntity entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
