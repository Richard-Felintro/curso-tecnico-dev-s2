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

                return BadRequest(erro.Message);
            }
        }

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
                return BadRequest(erro.Message);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult PatchById(FilmeDomain Filme,int id)
        {
            try
            {
                _filmeRepository.AtualizarIdUrl(id, Filme);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

        [HttpPatch]
        public IActionResult Patch(FilmeDomain Filme)
        {
            try
            {
                _filmeRepository.AtualizarIdCorpo(Filme);
                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }

    }
}
