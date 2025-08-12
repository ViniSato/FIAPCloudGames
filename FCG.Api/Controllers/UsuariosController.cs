using Azure;
using FCG.Api.Models.Requests;
using FCG.Api.Services.Mappers;
using FCG.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FCG.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly Services.Mappers.IUsuarioMapper _usuarioMapper;

        public UsuariosController(
            IUsuarioService usuarioService,
            Services.Mappers.IUsuarioMapper usuarioMapper)
        {
            _usuarioService = usuarioService;
            _usuarioMapper = usuarioMapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await _usuarioService.GetUsuarioByIdAsync(id);
            if (usuario == null)
                return NotFound("Usuário não encontrado");

            var response = _usuarioMapper.ToResponse(usuario);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dtos = await _usuarioService.GetAllAsync();
            var responses = dtos.Select(_usuarioMapper.ToResponse);
            return Ok(responses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsuario([FromBody] UsuarioRequest request)
        {
            if (request == null)
                return BadRequest("Requisição inválida");

            var dto = _usuarioMapper.ToDto(request);

            await _usuarioService.CreateUsuarioAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] UsuarioRequest request)
        {
            if (request == null)
                return BadRequest("Requisição inválida");

            var usuarioExistente = await _usuarioService.GetUsuarioByIdAsync(id);
            if (usuarioExistente == null)
                return NotFound("Usuário não encontrado");

            var dto = _usuarioMapper.ToDto(request);
            dto.Id = id; 

            await _usuarioService.UpdateUsuarioAsync(dto);
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var sucesso = await _usuarioService.DeleteUsuarioAsync(id);
            if (!sucesso)
                return NotFound("Usuário não encontrado");

            return NoContent(); 
        }
    }
}
