using FCG.Api.Services.Mappers;

namespace FCG.Api.IoC.Modules
{
    public class ApiModules
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<IUsuarioMapper, UsuarioMapper>();
        }
    }
}
