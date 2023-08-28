using wedapi.filmes.tarde.Domains;

namespace wedapi.filmes.tarde.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório GeneroRepository
    /// Define méotodos a serem implementados pelo repositório
    /// </summary>\
    public interface IGeneroRepository
    {
        /// <summary>
        /// Cadastrar um novo Gênero
        /// </summary>
        /// <param name="novoGenero">Objeto que será cadastrado</param>

        //TipoDeRetorno NomeMetodo(TipoParametro NomeParametro)
        void Cadastrar(GeneroDomain novoGenero);
        /// <summary>
        /// Retornar todos os gêneros cadastrados
        /// </summary>
        /// <returns>Uma lista de gêneros</returns>
        List<GeneroDomain> ListarTodos();

        /// <summary>
        /// Buscar um objeto através do seu id
        /// </summary>
        /// <param name="id">Id do objeto que será buscado</param>
        /// <returns>Objeto que foi buscado</returns>
        GeneroDomain BuscarPorId(int id);

        /// <summary>
        /// Atualiza um gênero, passando o id no corpo da requisição
        /// </summary>
        /// <param name="genero">Objeto gênero com as novas informações</param>

        /// <summary>
        /// Atualizar um gênero existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">IdGenero do objeto a ser atualizado</param>
        /// <param name="genero">O objeto com as novas informações</param>
        void AtualizarIdUrl(int id, GeneroDomain genero);

        /// <summary>
        /// Deletar um gênero existente
        /// </summary>
        /// <param name="id">GeneroId do objeto a ser deletado</param>
        void Deletar(int id);
        void AtualizarIdJson(GeneroDomain genero);
    }
}
