using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Resources;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;
using wedapi.filmes.tarde.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace wedapi.filmes.tarde.Controllers
{
    /// <summary>
    /// Define que a rota de uma requisição será no seguinte formato
    /// dominio/api/nomeController
    /// exemplo: http://localhost:5000/api/Genero
    /// </summary>
    [Route("api/[controller]")]

    /// <summary>
    /// Define que é um controlador de API
    /// </summary>
    [ApiController]

    /// <summary>
    /// Define que o tipo de resposta da API é JSON
    /// </summary>
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber os métodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia o _generoRepository para que haja referência aos membros do repositório
        /// </summary>
        public GeneroController()
        { 
            _generoRepository = new GeneroRepository();
        }

        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            try
            {
                //Faz a chamada do método para cadastrar
                _generoRepository.Cadastrar(novoGenero);

                //Retorna o status code
                return Created("Objeto criado",novoGenero);
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
                _generoRepository.Deletar(id);

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
                // Cria uma lista para receber os gêneros
                List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

                // Retorna o Status Code 200 e a lista de gêneros no formato JSON
                return StatusCode(200, ListaGeneros);
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
                GeneroDomain genero = _generoRepository.BuscarPorId(id);
                if (genero == null)
                {
                    return BadRequest("Gênero não encontrado");
                }

                return StatusCode(200, genero);
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUrl(int id, GeneroDomain genero)
        {
            GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);
            try
            {
                if (generoBuscado != null)
                {
                    _generoRepository.AtualizarIdJson(genero);
                    return StatusCode(200, genero);
                }
                return BadRequest();
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateJson(GeneroDomain genero)
        {
            try
            {
                if (genero != null)
                {
                    _generoRepository.AtualizarIdJson(genero);
                }
                return StatusCode(204);
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }
    }
}