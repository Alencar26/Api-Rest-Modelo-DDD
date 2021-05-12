using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestModeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
