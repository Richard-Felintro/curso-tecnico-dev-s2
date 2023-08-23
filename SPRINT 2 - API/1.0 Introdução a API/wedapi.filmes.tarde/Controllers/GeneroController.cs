using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;
using wedapi.filmes.tarde.Repositories;

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


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Cria uma lista para receber os gêneros
                _generoRepository.BuscarPorId(0);

                // Retorna o Status Code 200 e a lista de gêneros no formato JSON
                return Ok();
            }
            catch (Exception erro)
            {
                // Retorna um status code 400 BadRequest e a mensagem de erro
                return BadRequest(erro.Message);
            }
        }

        /// <summary>
        /// Endpoint que acessa o método de listar os gênero
        /// </summary>
        /// <returns>Lista de gêneros e um status code</returns>
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        // Cria uma lista para receber os gêneros
        //        List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

        //        // Retorna o Status Code 200 e a lista de gêneros no formato JSON
        //        return Ok(ListaGeneros);
        //    }
        //    catch (Exception erro)
        //    {
        //        // Retorna um status code 400 BadRequest e a mensagem de erro
        //        return BadRequest(erro.Message);
        //    }
        //}
    }
}