using FCG.Application.Interfaces;
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
        }
    }
}
