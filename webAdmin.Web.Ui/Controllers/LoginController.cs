using Microsoft.AspNetCore.Mvc;
using webAdmin.Web.Ui.Helper;
using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISessao _sessao;

        public LoginController(ISessao sessao)
        {
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            if (_sessao.BuscarSessaoDoUsuario() != null) return RedirectToAction("Index", "Home");
            return View();
        }

        public IActionResult RedefinirSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginViewModel loginModel)
        {
            UsuarioViewModel usuario = new()
            {
                Id = 1,
                Email = "tulio@teste.com.br",
                Login = "Tulio",
                Nome = loginModel.Login,
                Senha = "123456",
                DataCadastro = DateTime.Now,
                Perfil = Domain.Enums.PerfilEnum.Admin
            };

            _sessao.CriarSessaoDoUsuario(usuario);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }
    }
}
