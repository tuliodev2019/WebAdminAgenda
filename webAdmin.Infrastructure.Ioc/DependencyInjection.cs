using Microsoft.Extensions.DependencyInjection;
using webAdmin.Domain.Core.Interfaces.Repositories;
using webAdmin.Domain.Core.Interfaces.Services;
using webAdmin.Domain.Services.Services;
using webAdmin.InfraStructure.Data.Repositories;

namespace webAdmin.InfraStructure.Ioc
{
    public static class DependencyInjection
    {
        public static void DependencyInjectionServices(this IServiceCollection services)
        {
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
        }
        public static void DependencyInjectionRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
