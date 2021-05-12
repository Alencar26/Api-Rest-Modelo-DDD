using ApiRestModeloDDD.Application.Dtos;
using ApiRestModeloDDD.Application.Interfaces;
using ApiRestModeloDDD.Application.Interfaces.Mappers;
using ApiRestModeloDDD.Domain.Core.Interfaces.Services;
using ApiRestModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestModeloDDD.Application
{
    class ApplicationServiceProduto : IApplicationServiceProduto
    {

        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            IEnumerable<Produto> produtos = _serviceProduto.GetAll();
            return _mapperProduto.MapperListProdutoDto(produtos);
        }

        public ProdutoDto GetById(int id)
        {
            Produto produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            Produto produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}
