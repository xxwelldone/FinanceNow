using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FinanceNow.Entities.DTO
{
    public class UsuarioLoginDTO
    {
        [EmailAddress]
        [Required(ErrorMessage ="Informe o e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
