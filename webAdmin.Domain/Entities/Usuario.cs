using System.ComponentModel.DataAnnotations;
using webAdmin.Domain.Enums;

namespace webAdmin.Domain.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Login { get; set; }
        public string? Email { get; set; }
        public PerfilEnum? Perfil { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
