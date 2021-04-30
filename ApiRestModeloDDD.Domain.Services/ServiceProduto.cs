using ApiRestModeloDDD.Domain.Core.Interfaces.Repositories;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestModeloDDD.Domain.Services
{
    class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto _repository;

        public ServiceProduto(IRepositoryProduto repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
