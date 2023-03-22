using eCommerce.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository _repository;
        public UsuariosController()
        {
            _repository = new UsuarioRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repository.GetUsuarios());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetUsuarioById(id));
        }

    }
}
