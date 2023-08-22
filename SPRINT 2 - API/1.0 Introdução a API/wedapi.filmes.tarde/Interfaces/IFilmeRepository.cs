using wedapi.filmes.tarde.Domains;

namespace wedapi.filmes.tarde.Interfaces
{
    public interface IFilmeRepository
    {
        void Cadastrar(FilmeDomain novoGenero);

        /// <summary>
        /// Retornar todos os filmes cadastrados
        /// </summary>
        /// <returns>Uma lista de filmes</returns>
        List<FilmeDomain> ListarTodos();

        /// <summary>
        /// Buscar um objeto através do seu id
        /// </summary>
        /// <param name="id">Id do objeto que será buscado</param>
        /// <returns>Objeto que foi buscado</returns>
        FilmeDomain BuscarPorId(int id);

        /// <summary>
        /// Atualiza um filme, passando o id no corpo da requisição
        /// </summary>
        /// <param name="genero">Objeto filme com as novas informações</param>
        void AtualizarIdCorpo(FilmeDomain filme);
        /// <summary>
        /// Atualizar um filme existente passando o id pela URL da requisição
        /// </summary>
        /// <param name="id">Id do objeto a ser atualizado</param>
        /// <param name="genero">O objeto com as novas informações</param>
        void AtualizarIdUrl(int id, FilmeDomain filme);

        /// <summary>
        /// Deletar um filme existente
        /// </summary>
        /// <param name="id">GeneroId do objeto a ser deletado</param>
        void Deletar(int id);
    }
}
