using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Application.Interfaces.Mappers;
using ApiRestModeloDDD.Application.Interfaces;
using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiRestModeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            IEnumerable<Cliente> clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClienteDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            Cliente cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            Cliente cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}
