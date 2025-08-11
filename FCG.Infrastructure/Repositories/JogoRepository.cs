using FCG.Domain.Models;
using FCG.Infrastructure.Context;

namespace FCG.Infrastructure.Repositories
{
    public class JogoRepository : BaseRepository<Jogo>, Domain.Interfaces.IJogoRepository
    {
        public JogoRepository(FCGContext context) : base(context)
        {

        }
    }
}
