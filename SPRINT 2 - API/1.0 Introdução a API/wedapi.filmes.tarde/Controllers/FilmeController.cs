using Microsoft.AspNetCore.Mvc;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;
using wedapi.filmes.tarde.Repositories;

namespace wedapi.filmes.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FilmeController : ControllerBase
    {
        private IFilmeRepository _filmeRepository { get; set; }

        /// <summary>
        /// Instancia o _generoRepository para que haja referência aos membros do repositório
        /// </summary>
        public FilmeController()
        {
            _filmeRepository = new FilmeRepository();
        }

        /// <summary>
        /// Cadastra um novo filme
        /// </summary>
        /// <param name="novoFilme"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(FilmeDomain novoFilme)
        {
            try
            {
                _filmeRepository.Cadastrar(novoFilme);

                return Created("Objeto criado", novoFilme);
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Deleta um filme utilizando seu id para escolhê-lo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                //Faz a chamada do método para cadastrar
                _filmeRepository.Deletar(id);

                return NoContent();
            }
            catch (Exception erro)
            {

                return NotFound(erro.Message);
            }
        }

        /// <summary>
        /// Exibe todos os filmes cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<FilmeDomain> ListaFilmes = _filmeRepository.ListarTodos();

                // Retorna o Status Code 200 e a lista de gêneros no formato JSON
                return StatusCode(200, ListaFilmes);
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Exibe um gênero utilizando seu Id como parâmetro para escolhê-lo
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                FilmeDomain Filme = _filmeRepository.BuscarPorId(id);
                if (Filme == null)
                {
                    return BadRequest("Filme não encontrado");
                }

                // Retorna o Status Code 200 e a lista de gêneros no formato JSON
                return StatusCode(200, Filme);
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return NotFound(erro.Message);
            }
        }

        /// <summary>
        /// Atualiza um gênero utilizando seu Id como parâmetro para escolhê-lo
        /// </summary>
        /// <param name="Filme"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        public IActionResult PatchById(FilmeDomain Filme,int id)
        {
            FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(id);
            try
            {
                if (filmeBuscado != null)
                {
                    _filmeRepository.AtualizarIdUrl(id, filmeBuscado);
                    return StatusCode(200, filmeBuscado);
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Atualiza um filme utilizando seu Id no Json para escolhê-lo
        /// </summary>
        /// <param name="Filme"></param>
        /// <returns></returns>
        [HttpPatch]
        public IActionResult Patch(FilmeDomain Filme)
        {
            FilmeDomain filmeBuscado = _filmeRepository.BuscarPorId(Filme.IdFilme);
            try
            {
                if (filmeBuscado != null)
                {
                    _filmeRepository.AtualizarIdCorpo(Filme);
                    return StatusCode(200, filmeBuscado);
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
