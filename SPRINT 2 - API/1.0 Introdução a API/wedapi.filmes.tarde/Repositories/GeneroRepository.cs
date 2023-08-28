using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;

namespace wedapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private string StringConexao = "Data Source = NOTE01-S15; Initial Catalog = FilmesTarde; User ID = sa; Pwd = Senai@134";

        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdJson(GeneroDomain novoGenero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdate = "UPDATE Genero SET Nome = @NovoNome WHERE IdGenero = @Id";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@NovoNome", novoGenero.Nome);
                    cmd.Parameters.AddWithValue("@Id", novoGenero.IdGenero);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AtualizarIdUrl(int id, GeneroDomain novoGenero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryUpdate = "UPDATE Genero SET Nome = @NovoNome WHERE IdGenero = @Id";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(queryUpdate,con))
                {
                    cmd.Parameters.AddWithValue("@NovoNome", novoGenero.Nome);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public GeneroDomain BuscarPorId(int id)
        {
            GeneroDomain generoBuscado = new GeneroDomain();
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelect = "SELECT Nome FROM Genero WHERE IdGenero = (@IdBuscar)";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@IdBuscar", id);
                    cmd.ExecuteNonQuery();
                    //Executa a query e armazena os dados no Leitor
                    SqlDataReader Leitor;
                    Leitor = cmd.ExecuteReader();

                    //Enquanto houverem registros a serem lidos no Leitor
                    while (Leitor.Read())
                    {
                        generoBuscado.IdGenero = Convert.ToInt32(Leitor[0]);
                        generoBuscado.Nome = Convert.ToString(Leitor["Nome"]);
                    }
                }
            }
        return generoBuscado;
        }

        /// <summary>
        /// Cadastrar um novo objeto
        /// </summary>
        /// <param name="novoGenero">Objeto com as informações que serão cadastradas</param>
        public void Cadastrar(GeneroDomain novoGenero)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryInsert = "INSERT INTO Genero(Nome) VALUES (@Nome)";
                // Abre a conexão com o banco
                con.Open();

                // Declara o comando com seu conteúdo (queryInsert) e conexão (con)
                using (SqlCommand cmd = new SqlCommand(queryInsert,con))
                {
                    cmd.Parameters.AddWithValue("@Nome", novoGenero.Nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Deletar(int id)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryDelete = "DELETE FROM Genero WHERE IdGenero = (@IdDeletar)";
                // Abre a conexão com o banco
                con.Open();

                // Declara o comando com seu conteúdo (queryInsert) e conexão (con)
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdDeletar", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Buscar um objeto através do seu id
        /// </summary>
        /// <param name="id">Id do objeto que será buscado</param>
        /// <returns>Objeto que foi buscado</returns>
        public List<GeneroDomain> ListarTodos()
        {
            //Cria uma lista de gêneros aonde seram armazenados os dados
            List<GeneroDomain> ListaGeneros = new List<GeneroDomain>();
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                //Declara a instrução a ser executada.
                string QueryListarTodos = "SELECT IdGenero,Nome FROM Genero";
                //Abre a conexão com o branco de dado.
                con.Open();

                //Declara o SqlDataReader para ler a tabela no banco de dados
                SqlDataReader Leitor;

                //Declara o SqlCommand passando a query que será executada e a conexão
                using (SqlCommand cmd = new SqlCommand(QueryListarTodos,con))
                {
                    //Executa a query e armazena os dados no Leitor
                    Leitor = cmd.ExecuteReader();

                    //Enquanto houverem registros a serem lidos no Leitor
                    while(Leitor.Read()) 
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            IdGenero = Convert.ToInt32(Leitor[0]),
                            Nome = Convert.ToString(Leitor["Nome"])
                        };
                    ListaGeneros.Add(genero);
                    }
                }
            }
        return ListaGeneros;
        }
    }
}
