using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ApiRestModeloDDD.Infra.CrossCutting.Interfaces
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}
