using BibliotecaAPI.Domains;
using BibliotecaAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BibliotecaAPI.Controllers
{

    //Controller -> recebe as requisicoes http e devolve respostas (json)
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : Controller
    {
        private readonly LivroService _service;

        public LivroController(LivroService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Livro> livros = _service.Listar();
            return Ok(livros);
        }

        [HttpPost]

        public ActionResult Cadastrar(Livro livro)
        {
            try
            {
                Livro novoLivro = _service.Adicionar(livro);

                return Created("Livro criado com sucesso! ", livro);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Atualizar(int id, Livro livro)
        {
            try
            {
                bool atualizado = _service.Atualizar(id, livro);

                if (!atualizado)
                {
                    return NotFound("Livro nao foi encontrado.");
                }

                return Created("Livro foi atualizado com sucesso", livro);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
