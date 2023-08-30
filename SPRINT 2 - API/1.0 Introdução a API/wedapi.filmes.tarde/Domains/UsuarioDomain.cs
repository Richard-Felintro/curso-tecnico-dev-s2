using System.ComponentModel.DataAnnotations;

namespace wedapi.filmes.tarde.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Nome do usuário não determinado.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email do usuário não determinado.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha do usuário não determinada.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Permissão do usuário não determinada.")]
        public bool PermissaoAdmin { get; set; }
    }
}
