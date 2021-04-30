using ApiRestModeloDDD.Domain.Core.Interfaces.Repositories;
using ApiRestModeloDDD.Domain.Entities;

namespace ApiRestModeloDDD.Infra.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext _sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
