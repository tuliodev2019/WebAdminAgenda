using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Entities;
using webAdmin.InfraStructure.Data.Context;

namespace webAdmin.InfraStructure.Data.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext dataContext) : base(dataContext)
        { }
    }
}
