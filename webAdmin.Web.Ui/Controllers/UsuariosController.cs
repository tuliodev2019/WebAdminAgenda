using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webAdmin.Domain.Core.Interfaces.Services;
using webAdmin.Domain.Entities;
using webAdmin.Domain.Services.Services;
using webAdmin.Web.Ui.Helper;
using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;
        private readonly ISessao _sessao;

        public UsuariosController(IUsuarioService usuarioService, IMapper mapper, ISessao sessao)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
            _sessao = sessao;
        }

        public IActionResult Index()
        {
            var _usuarios = _usuarioService.GetAll();
            var _usuarioViewModel = _mapper.Map<List<UsuarioViewModel>>(_usuarios);

            return View(_usuarioViewModel);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            var _usuarioViewModel = _mapper.Map<UsuarioViewModel>(_usuarioService.GetById(id));

            if (id == 0)
                return View(new UsuarioViewModel());
            else
                return View(_usuarioViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id, Nome, Login, Email, Perfil, Senha, DataCadastro, DataAtualizacao")] UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var _usuario = _mapper.Map<Usuario>(usuarioViewModel);

                if (usuarioViewModel.Id == 0)
                    _usuarioService.Add(_usuario);
                else
                    _usuarioService.Update(_usuario);

                TempData["MensagemSucesso"] = "Usuário Cadastrado com sucesso";

                return RedirectToAction(nameof(Index));
            }

            return View(usuarioViewModel);
        }

        public IActionResult Delete(int id)
        {
            var _usuario = _usuarioService.GetById(id);

            _usuarioService.Remove(_usuario);

            TempData["MensagemSucesso"] = "Usuário excluido com sucesso";

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit([Bind("Id, Nome, Login, Email, Perfil, Senha, DataCadastro, DataAtualizacao")] UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuarioLogado = _mapper.Map<UsuarioViewModel>(_sessao.BuscarSessaoDoUsuario());
                var _usuarioViewModel = _mapper.Map<UsuarioViewModel>(_usuarioService.GetById(usuarioLogado.Id));

                return View(_usuarioViewModel);
            }

            return View(usuarioViewModel);
        }
    }
}
