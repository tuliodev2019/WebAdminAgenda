using System.ComponentModel.DataAnnotations;

namespace webAdmin.Web.Ui.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite o Login")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Digite a Senha")]
        public string? Senha { get; set; }
    }
}
