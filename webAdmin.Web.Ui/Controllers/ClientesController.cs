using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using webAdmin.Domain.Core.Interfaces.Services;
using webAdmin.Domain.Entities;
using webAdmin.Web.Ui.ViewModels;

namespace webAdmin.Web.Ui.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClientesController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var _clientes = _clienteService.GetAll();
            var _clienteViewModels = _mapper.Map<List<ClienteViewModel>>(_clientes);

            return View(_clienteViewModels);
        }

        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            var _clienteViewModel = _mapper.Map<ClienteViewModel>(_clienteService.GetById(id));

            if (id == 0)
                return View(new ClienteViewModel());
            else
                return View(_clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,Nome,Email,Celular")] ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var _cliente = _mapper.Map<Cliente>(clienteViewModel);

                if (clienteViewModel.Id == 0)
                    _clienteService.Add(_cliente);
                else
                    _clienteService.Update(_cliente);

                TempData["MensagemSucesso"] = "Cliente Cadastrado com sucesso";

                return RedirectToAction(nameof(Index));
            }

            return View(clienteViewModel);
        }

        public IActionResult Delete(int id)
        {
            var _cliente = _clienteService.GetById(id);
            
            _clienteService.Remove(_cliente);

            TempData["MensagemSucesso"] = "Cliente excluido com sucesso";

            return RedirectToAction(nameof(Index));
        }
    }
}
