using System.ComponentModel.DataAnnotations;

namespace webAdmin.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public int UsuarioId { get; set; }
    }
}
