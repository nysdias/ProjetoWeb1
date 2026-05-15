using ProjetoWeb1.Models;
using MySql.Data.MySqlClient;
using ProjetoWeb1.Interfaces;

namespace ProjetoWeb1.Repositorios
{
    public class UsuarioRepositorio(IConfiguration config) : IUsuarioRepositorio //herança
    {
        private readonly string _connectionString = config.GetConnectionString("Conexão");

        public LoginViewModel Validar(string email, string senha)
        {
            using var conn = new MySqlConnection(_connectionString);
            conn.Open();

            var sql = "SELECT * FROM Usuarios WHERE Email = @email AND Senha = @senha";

            var cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return new LoginViewModel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Email = reader["Email"].ToString(),
                    Nivel = reader["Nivel"].ToString(),
                };

            }
            return null;
        }
    }
}
