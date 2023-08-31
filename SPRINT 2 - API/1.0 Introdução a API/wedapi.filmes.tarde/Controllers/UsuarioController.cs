using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System.ComponentModel.DataAnnotations;
using wedapi.filmes.tarde.Domains;
using wedapi.filmes.tarde.Interfaces;
using wedapi.filmes.tarde.Repositories;

namespace wedapi.filmes.tarde.Controllers
{
    // Define a rota da requisição no formato: "dominio/api/nomeController".
    [Route("api/[controller]")]

    // Define esta classe como um controlador de API.
    [ApiController]

    //Determina que este Controller produzirá respostas em JSON.
    [Produces("application/json")]  
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Quando o GeneroController é ativado ele já criará um repository a ser utilizado.
        /// </summary>
        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Faz login a um usuário, utilizando seu email e senha como parametros.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        [HttpPut("{email}&{senha}")]
        public IActionResult Login(string email, string senha)
        {
            try
            {
                UsuarioDomain usuario = _usuarioRepository.Login(email, senha);
                if (usuario == null)
                {
                    return NotFound("Usuário não encontrado. Senha ou email inválidos.");
                }
                return Ok(usuario);
            }
            catch (Exception erro)
            {
                return NotFound(erro.Message);
            }
        }
        //public IActionResult Post(UsuarioDomain user)
        //{
        //    try
        //    {
        //        // Faz o método de cadastro de usuário, utilizando o user.
        //        _usuarioRepository.Cadastrar(user);
        //        // Se for criado com sucesso, retorne o usuário criado e um Status Code 201.
        //        return Created("Usuário cadastrado com sucesso.", user);
        //    }
        //    // Caso dê um erro
        //    catch (Exception erro)
        //    {
        //        // Retorna um Status Code 400.
        //        return BadRequest(erro.Message);
        //    }
        //}
    }
}
