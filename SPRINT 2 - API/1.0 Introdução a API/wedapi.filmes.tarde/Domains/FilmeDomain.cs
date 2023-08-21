using System.ComponentModel.DataAnnotations;

namespace wedapi.filmes.tarde.Domains
{
    /// <summary>
    /// Classe representante da entidade Filme
    /// </summary>
    public class FilmeDomain
    {
        public int IdFilme { get; set; }
        [Required(ErrorMessage = "Nome do filme não determinado")]
        public string? Titulo { get; set; }
        public int IdGenero { get; set; }
        // Referência para a classe gênero
        public GeneroDomain? Genero { get; set; }
    }
}
