using ProjetoWeb1.Models;

namespace ProjetoWeb1.Repositorios
{
    public class UsuarioRepositorio(IConfiguration config)
    {
        private readonly string _connectionString = config.GetConnectionString("Conexão");

        public LoginViewModel Validar(string email, string senha) 
        {
            using var conn = new MySqlConnection(_connectionString);
        
        }
    }
}
