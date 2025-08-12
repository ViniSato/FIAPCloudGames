using FCG.Domain.ValueObjects;

namespace FCG.Application.Interfaces
{
    public interface IAuthService
    {
        Task<string> AutenticarAsync(Email email, Senha senha);
    }
}