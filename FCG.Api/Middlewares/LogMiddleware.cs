namespace FCG.Api.Middlewares
{
    public class LogMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine($"[LOG] Requisição: {context.Request.Method} {context.Request.Path}");

            await next(context);

            Console.WriteLine($"[LOG] Resposta: {context.Response.StatusCode}");
        }
    }
}