using FCG.Api.Models.Requests;
using FCG.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IJogoMapper = FCG.Api.Services.Mappers.IJogoMapper;

namespace FCG.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JogosController : ControllerBase
    {
        private readonly IJogoService _jogoService;
        private readonly IJogoMapper _jogoMapper;

        public JogosController(IJogoService jogoService, IJogoMapper jogoMapper)
        {
            _jogoService = jogoService;
            _jogoMapper = jogoMapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dto = await _jogoService.GetByIdAsync(id);
            var response = _jogoMapper.ToResponse(dto);
            return Ok(response);
        }

        [Authorize]
        [HttpGet("biblioteca")]
        public async Task<IActionResult> GetAll()
        {
            var dtos = await _jogoService.GetAllAsync();
            var responses = dtos.Select(_jogoMapper.ToResponse);
            return Ok(responses);
        }

        [Authorize(Roles = "admin")]
        [HttpPost("cadastrar")]
        public async Task<IActionResult> Create([FromBody] JogoRequest request)
        {
            var dto = _jogoMapper.ToDto(request);
            await _jogoService.CreateAsync(dto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] JogoRequest request)
        {
            var dto = _jogoMapper.ToDto(request);
            dto.Id = id;
            await _jogoService.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sucesso = await _jogoService.DeleteAsync(id);
            if (!sucesso)
                return NotFound("Jogo não encontrado");

            return NoContent();
        }
    }
}