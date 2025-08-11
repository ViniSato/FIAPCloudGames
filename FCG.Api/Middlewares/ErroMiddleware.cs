namespace FCG.Api.Middlewares
{
    public class ErroMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Ocorreu um erro inesperado.");
            }
        }
    }
}
