using FCG.Api.Models.Requests;
using FCG.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FCG.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        private readonly IJogoService _jogoService;
        public JogosController(IJogoService jogoService)
        {
            _jogoService = jogoService ?? throw new ArgumentNullException(nameof(jogoService));
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetJogoById(int id)
        {
            var jogo = await _jogoService.GetJogoByIdAsync(id);
            if (jogo == null)
            {
                return NotFound();
            }
            return Ok(jogo);
        }
    }
}
