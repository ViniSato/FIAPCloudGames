using FCG.Application.Interfaces;
using FCG.Domain.Interfaces;

namespace FCG.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenGenerator _tokenGenerator;

        public AuthService(
            IUsuarioRepository usuarioRepository,
            IPasswordHasher passwordHasher,
            ITokenGenerator tokenGenerator)
        {
            _usuarioRepository = usuarioRepository;
            _passwordHasher = passwordHasher;
            _tokenGenerator = tokenGenerator;
        }

        public async Task<string> AutenticarAsync(string email, string senha)
        {
            var usuario = await _usuarioRepository.GetByEmail(email);
            if (usuario == null)
                throw new UnauthorizedAccessException("Credenciais inválidas");

            var senhaValida = _passwordHasher.Verify(senha, usuario.SenhaHash);
            if (!senhaValida)
                throw new UnauthorizedAccessException("Credenciais inválidas");

            var token = _tokenGenerator.GerarToken(usuario);
            return token;
        }
    }
}