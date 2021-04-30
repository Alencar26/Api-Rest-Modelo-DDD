using System.Collections.Generic;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Core.Interfaces.Repositories;

namespace ApiRestModeloDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        // uso de sintaxe simplificada para métodos usando => 

        public void Add(TEntity obj) => _repository.Add(obj);

        // dessa forma posso omitir o 'return'
        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        // dessa forma posso omitir o 'return'
        public TEntity GetById(int id) => _repository.GetById(id); 

        public void Remove(TEntity obj) => _repository.Remove(obj);

        public void Update(TEntity obj) => _repository.Update(obj);

    }
}
