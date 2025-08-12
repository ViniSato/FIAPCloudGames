using FCG.Domain.Models;

namespace FCG.Application.Interfaces
{
    public interface ITokenGenerator
    {
        string GerarToken(Usuario usuario);
    }
}