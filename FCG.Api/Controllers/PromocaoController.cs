using FCG.Api.Models.Requests;
using FCG.Api.Models.Responses;
using FCG.Application.Interfaces;
using FCG.Api.Services.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FCG.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PromocoesController : ControllerBase
    {
        private readonly IPromocaoService _promocaoService;
        private readonly IPromocaoMapper _promocaoMapper;

        public PromocoesController(IPromocaoService promocaoService, IPromocaoMapper promocaoMapper)
        {
            _promocaoService = promocaoService;
            _promocaoMapper = promocaoMapper;
        }

        [Authorize(Roles = "Administrador")]
        [HttpPost("{jogoId}")]
        public async Task<IActionResult> Create(int jogoId, [FromBody] PromocaoRequest request)
        {
            var dto = _promocaoMapper.ToDto(request);
            var result = await _promocaoService.CreateAsync(jogoId, dto);
            var response = _promocaoMapper.ToResponse(result);
            return Ok(response);
        }

        [Authorize]
        [HttpGet("jogo/{jogoId}")]
        public async Task<IActionResult> GetByJogo(int jogoId)
        {
            var result = await _promocaoService.GetByJogoAsync(jogoId);
            var responses = result.Select(_promocaoMapper.ToResponse);
            return Ok(responses);
        }

        [Authorize(Roles = "Administrador")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var sucesso = await _promocaoService.DeleteAsync(id);
            if (!sucesso)
                return NotFound("Promoção não encontrada");

            return NoContent();
        }
    }
}