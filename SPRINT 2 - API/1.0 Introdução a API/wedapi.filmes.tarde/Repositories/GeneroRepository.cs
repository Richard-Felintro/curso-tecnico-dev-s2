using System.Data.SqlClient;
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

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
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
