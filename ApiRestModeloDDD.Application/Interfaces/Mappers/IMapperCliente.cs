using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClienteDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}
