using ApiRestModeloDDD.Domain.Core.Interfaces.Repositories;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ApiRestModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repository;

        public ServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
