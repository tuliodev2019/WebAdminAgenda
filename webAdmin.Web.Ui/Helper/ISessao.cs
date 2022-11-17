using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioViewModel usuario);
        void RemoverSessaoUsuario();
        UsuarioViewModel BuscarSessaoDoUsuario();
    }
}
