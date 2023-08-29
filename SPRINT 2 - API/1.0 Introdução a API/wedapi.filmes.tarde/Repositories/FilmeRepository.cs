using System.Data.SqlClient;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;

namespace wedapi.filmes.tarde.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private string StringConexao = "Data Source = NOTE01-S15; Initial Catalog = FilmesTarde; User ID = sa; Pwd = Senai@134";
        public void AtualizarIdCorpo(FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "UPDATE Filme SET Titulo = @NovoTitulo, IdGenero = @NovoIdGenero WHERE IdFilme = @id";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@NovoTitulo", filme.Titulo);
                    cmd.Parameters.AddWithValue("@NovoIdGenero", filme.IdGenero);
                    cmd.Parameters.AddWithValue("@id", filme.IdFilme);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, FilmeDomain filme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "UPDATE Filme SET Titulo = @NovoTitulo, IdGenero = @NovoIdGenero WHERE IdFilme = @id";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@NovoTitulo", filme.Titulo);
                    cmd.Parameters.AddWithValue("@NovoIdGenero", filme.IdGenero);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public FilmeDomain BuscarPorId(int id)
        {
            FilmeDomain FilmeBuscado = new FilmeDomain();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "SELECT IdFilme,Titulo,IdGenero FROM Filme WHERE IdFilme = @id";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    SqlDataReader Leitor;
                    Leitor = cmd.ExecuteReader();
                    while (Leitor.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(Leitor[0]),
                            Titulo = Convert.ToString(Leitor[1]),
                            IdGenero = Convert.ToInt32(Leitor[2]),
                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(Leitor[2]),
                                Nome = Convert.ToString(Leitor[3]),
                            }
                        };
                    }
            }
            return FilmeBuscado;
        }

        public void Cadastrar(FilmeDomain novoFilme)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryInsert = "INSERT INTO Filme(IdGenero,Titulo) VALUES (@IdGenero,@Titulo)";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QueryInsert,con))
                {
                    cmd.Parameters.AddWithValue("@IdGenero", novoFilme.IdGenero);
                    cmd.Parameters.AddWithValue("@Titulo", novoFilme.Titulo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QueryDelete = "DELETE FROM Filme WHERE IdFilme = @IdFilme";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QueryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdFilme", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FilmeDomain> ListarTodos()
        {
            List<FilmeDomain> Lista = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = "SELECT Filme.IdFilme, Filme.Titulo, Genero.IdGenero, Genero.Nome FROM Filme LEFT JOIN Genero ON Genero.IdGenero = Filme.IdGenero";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(QuerySelect, con))
                {
                    SqlDataReader Leitor;
                    Leitor = cmd.ExecuteReader();
                    while (Leitor.Read())
                    {
                        FilmeDomain filme = new FilmeDomain()
                        {
                            IdFilme = Convert.ToInt32(Leitor[0]),
                            Titulo = Convert.ToString(Leitor[1]),
                            IdGenero = Convert.ToInt32(Leitor[2]),
                            Genero = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(Leitor[2]),
                                Nome = Convert.ToString(Leitor[3]),
                            }
                        };
                    Lista.Add(filme);
                }
            }
        }
        return Lista;
        }
    }
}
