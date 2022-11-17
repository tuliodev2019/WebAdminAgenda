using System.ComponentModel.DataAnnotations;
using webAdmin.Domain.Enums;

namespace webAdmin.Web.Ui.ViewModels
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o Nome do usuario")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite o Login do usuario")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Digite o Email do usuario")]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Digite o Perfil do usuario")]
        public PerfilEnum? Perfil { get; set; }

        [Required(ErrorMessage = "Digite a senha do usuario")]
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now.Date;

        //public virtual List<ClienteViewModel>? ClienteViews { get; set; }
        //public bool SenhaValida(string senha)
        //{
        //    return Senha == "1234"; // senha.GerarHash();
        //}
        //public void SetSenhaHash()
        //{
        //    Senha = "1234"; // Senha.GerarHash();
        //}
        //public string GerarNovaSenha()
        //{
        //    string novaSenha = Guid.NewGuid().ToString().Substring(0, 8);
        //    Senha = "1234"; // novaSenha.GerarHash();
        //    return novaSenha;
        //}
        //public string AtualizarSenha(string novaSenha)
        //{
        //    string Senha = "1234"; // novaSenha.GerarHash();
        //    return Senha;
        //}
    }
}
