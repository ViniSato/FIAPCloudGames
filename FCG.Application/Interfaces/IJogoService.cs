using FCG.Domain.Models;

namespace FCG.Application.Interfaces
{
    public interface IJogoService
    {
        public Task<Jogo> GetJogoByIdAsync(int id);
    }
}
