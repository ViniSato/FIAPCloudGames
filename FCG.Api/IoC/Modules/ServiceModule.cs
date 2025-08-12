using FCG.Application.Interfaces;
using FCG.Application.Mappers;
using FCG.Application.Services;

namespace FCG.Api.IoC.Modules
{
    public class ServiceModule
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IJogoService, JogoService>();
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<IUsuarioMapper, UsuarioMapper>();
            services.AddTransient<IJogoMapper, JogoMapper>();
            services.AddTransient<ITokenGenerator, TokenGenerator>();
        }
    }
}
