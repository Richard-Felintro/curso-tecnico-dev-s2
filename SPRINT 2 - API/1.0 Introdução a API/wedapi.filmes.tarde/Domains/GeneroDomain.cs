using System.ComponentModel.DataAnnotations;

namespace wedapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe representante da entidade Genero
    /// </summary>
    public class GeneroDomain
    {
        public int IdGenero { get; set; }
        [Required(ErrorMessage = "Nome de gênero não determinado")]
        public string? Nome { get; set; }
    }
}
