using FCG.Api.Middlewares;

namespace FCG.Api.IoC.Modules
{
    public class MiddlewareModule
    {
        public static void InjectDependencies(IServiceCollection services)
        {
            services.AddTransient<LogMiddleware>();
            services.AddTransient<ErroMiddleware>();
        }
    }
}
