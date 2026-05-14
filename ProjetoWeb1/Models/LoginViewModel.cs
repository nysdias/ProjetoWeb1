namespace ProjetoWeb1.Models
{
    public class LoginViewModel
    {
        // encapsulamento - modificadores get; set;
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string Nivel { get; set; } = "Funcionario";
    }
}
