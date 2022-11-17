using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult?> InvokeAsync()
        {
            var sessaoUsuario = HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            var usuario = JsonConvert.DeserializeObject<UsuarioViewModel>(sessaoUsuario);
            return View(usuario);
        }
    }
}
