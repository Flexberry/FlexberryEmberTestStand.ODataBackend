namespace EmberFlexberryDummy
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    public class PrivateNetworkAccessMiddleware
    {
        private readonly RequestDelegate _next;

        public PrivateNetworkAccessMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Method == "OPTIONS")
            {
                if (context.Request.Headers.TryGetValue("Access-Control-Request-Private-Network", out var requestPrivateNetworkValue) &&
                    string.Equals(requestPrivateNetworkValue, "true", StringComparison.OrdinalIgnoreCase))
                {
                    context.Response.Headers["Access-Control-Allow-Private-Network"] = "true";
                }
            }

            await _next(context);
        }
    }
}
