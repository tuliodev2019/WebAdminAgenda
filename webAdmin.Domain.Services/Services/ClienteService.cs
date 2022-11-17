using AutoMapper;
using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Core.Interfaces.Services;
using webAdmin.Domain.Entities;

namespace webAdmin.Domain.Services.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper) : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }
    }
}
