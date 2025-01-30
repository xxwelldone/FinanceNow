namespace FinanceNow.Entities
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NomeCompleto { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? Celular { get; set; }
        public string? CPF { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }




    }
}
