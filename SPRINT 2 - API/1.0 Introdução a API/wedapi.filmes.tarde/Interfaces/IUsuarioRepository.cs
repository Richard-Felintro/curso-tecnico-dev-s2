using wedapi.filmes.tarde.Domains;

namespace wedapi.filmes.tarde.Interfaces
{
    // Interface responsável pelo UsuarioRepository
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo usuário.
        /// </summary>
        /// <param name="NovoUsuario"></param>
        void Cadastrar(UsuarioDomain NovoUsuario);

        /// <summary>
        /// Deleta um usuário existente.
        /// </summary>
        /// <param name="NovoUsuario"></param>
        UsuarioDomain Login (string email, string senha);
    }
}
