using FCG.Application.Interfaces;
using FCG.Domain.Interfaces;
using FCG.Domain.Models;

namespace FCG.Application.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }

        public async Task<Jogo> GetJogoByIdAsync(int id)
        {
            var jogo = await _jogoRepository.GetById(id); 
            if (jogo == null)
            {
                throw new KeyNotFoundException("Jogo not found");
            }
            return jogo;
        }
    }
}
