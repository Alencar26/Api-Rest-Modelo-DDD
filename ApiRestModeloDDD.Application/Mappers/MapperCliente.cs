using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Application.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestModeloDDD.Application.Mappers
{
    public class MapperCliente : IMapperCliente
    {
        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            return new Cliente()
            {
                Id = clienteDto.Id.Value,
                Nome = clienteDto.Nome,
                Sobrenome = clienteDto.Sobrenome,
                Email = clienteDto.Email
            };
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            return new ClienteDto()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Nome,
                Email = cliente.Email
            };
        }

        public IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes)
        {
            return clientes.Select(cliente => new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            });
        }
    }
}
