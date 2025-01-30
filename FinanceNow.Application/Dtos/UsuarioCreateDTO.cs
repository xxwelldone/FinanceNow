using System.ComponentModel.DataAnnotations;

namespace FinanceNow.Entities.DTO
{
    public class UsuarioCreateDTO
    {
        [Required(ErrorMessage = "Informe o nome completo")]
        [MaxLength(100)]
        public string NomeCompleto { get; set; }
        [Required]
        public DateOnly? DataNascimento { get; set; }
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [Phone]
        [Required]
        public string? Celular { get; set; }
        [Required]
        public string? CPF { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
