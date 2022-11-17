using System.ComponentModel.DataAnnotations;

namespace webAdmin.Web.Ui.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Digite o Email")]
        [EmailAddress(ErrorMessage = "O email não é válido")]
        public string? Email { get; set; }
        
        [Required(ErrorMessage = "Digite o Celular")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string? Celular { get; set; }
    }
}
