using System.Data.SqlClient;
using System.Numerics;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;

namespace wedapi.filmes.tarde.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source = NOTE01-S15; Initial Catalog = FilmesTarde; User ID = sa; Pwd = Senai@134";
        /// <summary>
        /// Cadastra um novo usuário.
        /// </summary>
        /// <param name="NovoUsuario"></param>
        public void Cadastrar(UsuarioDomain NovoUsuario)
        {
            // Cria conexão com o StringConexao.
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Determina a query a ser feita no SQL.
                string QueryInsert = "INSERT INTO Usuario VALUES (@UserName,@UserEmail,@UserPassword,@UserAdmin)";
                // Abre a conexão com o banco de dados.
                con.Open();
                // Declara o comando e determina que ele utilizará a QueryInsert e a conexão anteriormente determinadas.
                using (SqlCommand cmd = new SqlCommand(QueryInsert, con))
                {
                    // Parametros são declarados, para que o JSON do NovoUsuario seja utilizado no cadastro.
                    cmd.Parameters.AddWithValue("@UserName", NovoUsuario.UserName);
                    cmd.Parameters.AddWithValue("@UserEmail", NovoUsuario.Email);
                    cmd.Parameters.AddWithValue("@UserPassword", NovoUsuario.Senha);
                    cmd.Parameters.AddWithValue("@UserAdmin", NovoUsuario.PermissaoAdmin);
                    // Executa o comando.
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public UsuarioDomain Login(string email, string senha)
        {
            // Cria conexão com o StringConexao.
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Determina a query a ser feita no SQL.
                string QueryLogin = "SELECT IdUsuario,UserName,Email,Senha,PermissaoAdmin FROM Usuario WHERE Email = @email AND Senha = @senha";
                // Abre a conexão com o banco de dados.
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QueryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    SqlDataReader Leitor;
                    Leitor = cmd.ExecuteReader();
                    while (Leitor.Read())
                    {
                        UsuarioDomain userLogin = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(Leitor[0]),
                            UserName = Convert.ToString(Leitor[1]),
                            Email = Convert.ToString(Leitor[2]),
                            Senha = Convert.ToString(Leitor[3]),
                            PermissaoAdmin = (bool)Leitor[4]
                        };
                        return userLogin;
                    }
                }
            }
            return null;
        }
    }
}