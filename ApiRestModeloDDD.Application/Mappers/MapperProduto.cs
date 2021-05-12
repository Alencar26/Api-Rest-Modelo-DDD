using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Application.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApiRestModeloDDD.Application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            return new Produto()
            {
                Id = produtoDto.Id.Value,
                Nome = produtoDto.Nome,
                Valor = produtoDto.Valor
            };
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            return new ProdutoDto()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }

        public IEnumerable<ProdutoDto> MapperListProdutoDto(IEnumerable<Produto> produtos)
        {
            return produtos.Select(produto => new ProdutoDto
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            });
        }
    }
}
