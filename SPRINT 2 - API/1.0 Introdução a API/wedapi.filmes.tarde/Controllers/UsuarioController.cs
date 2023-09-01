using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata;
using System.Security.Claims;
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
        [HttpPut]
        public IActionResult Login(UsuarioDomain usuarioLogin)
        {
            try
            {
                UsuarioDomain usuario = _usuarioRepository.Login(usuarioLogin);
                // Se o usuário for nulo (inexistente)
                if (usuario == null)
                {
                    // Retornar não encontrado
                    return NotFound("Usuário não encontrado. Senha ou email inválidos.");
                }
                // Caso encontre o usuário buscado, prossegue para a criação do Token

                // Definir as claims que serão fornecidos no Token
                var claims = new[]
                {
                    // Formato da claim(tipo, valor)
                    new Claim(JwtRegisteredClaimNames.Jti,usuarioLogin.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Email,usuarioLogin.Email.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name,usuarioLogin.UserName.ToString()),
                    new Claim(ClaimTypes.Role,usuario.PermissaoAdmin.ToString()),
                    // Claims customizadas existem
                    // new Claim("Custom claim name", "Claim value")
                };
                // Define a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("filmes-chave-autenticacao-webapi-dev"));

                // Definir as credenciais do token
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                // Gerar o token
                var token = new JwtSecurityToken
                (
                    // Emissor do token
                    issuer: "webapi.filmes.tarde",
                    // Destinatário
                    audience: "webapi.filmes.tarde",

                    // Dados definidos nas Claims
                    claims : claims,

                    // Tempo de expiração
                    expires: DateTime.Now.AddMinutes(5),

                    // Credenciais do token
                    signingCredentials : creds
                );

                // Retorna o token criado
                return Ok(new{token = new JwtSecurityTokenHandler().WriteToken(token)});
                // return Ok(usuario);
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
