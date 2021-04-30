using ApiRestModeloDDD.Domain.Core.Interfaces.Repositories;
using ApiRestModeloDDD.Domain.Entities;

namespace ApiRestModeloDDD.Infra.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext _sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
