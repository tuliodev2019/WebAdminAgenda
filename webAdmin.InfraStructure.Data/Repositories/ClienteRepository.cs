using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Entities;
using webAdmin.InfraStructure.Data.Context;

namespace webAdmin.InfraStructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(DataContext dataContext) : base(dataContext)
        { }
    }
}
