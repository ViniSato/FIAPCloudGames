using FCG.Domain.Interfaces;
using FCG.Domain.Models;
using FCG.Infrastructure.Context;
using Microsoft.Extensions.Logging;

namespace FCG.Infrastructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FCGContext context, ILogger<UsuarioRepository> logger) : base(context, logger)
        {

        }
    }
}
