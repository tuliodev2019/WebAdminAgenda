using AutoMapper;
using webAdmin.Domain.Entities;
using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            #region ViewModelToDomain
            
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<UsuarioViewModel, Usuario>();

            #endregion

            #region DomainToViewModel

            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();

            #endregion
        }
    }
}
