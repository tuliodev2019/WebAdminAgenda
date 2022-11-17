using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Core.Interfaces.Services;
using webAdmin.Domain.Entities;

namespace webAdmin.Domain.Services.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
    }
}
