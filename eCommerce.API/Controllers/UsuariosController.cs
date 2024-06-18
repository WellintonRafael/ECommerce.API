using eCommerce.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuariosController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listaDeUsuarios = await _repository.GetAll();

            return Ok(listaDeUsuarios);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Usuario? usuario = await _repository.Get(id);

            if (usuario == null) return NotFound("Usuário não encontrado");

            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Usuario usuario)
        {
            await _repository.Add(usuario);

            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromBody] Usuario usuario, int id)
        {
            await _repository.Update(usuario);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);

            return Ok();
        }
    }
}
