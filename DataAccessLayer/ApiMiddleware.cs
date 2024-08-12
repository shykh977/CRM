namespace BTG_CRM.DataAccessLayer
{
    public class ApiMiddleware
    {
        private readonly RequestDelegate _next;
        private
        const string CrmApi = "CrmApi";
       
        public ApiMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            
            
            var remoteIpAddress = context.Response.HttpContext.Connection.RemoteIpAddress;

            if (!context.Request.Headers.TryGetValue(CrmApi, out
                    var extractedApiKey))
            {
                context.Response.StatusCode = 808;
               
                await context.Response.WriteAsync("Unauthorized client");
                return;
            }
            
            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var apiKey = appSettings.GetValue<string>(CrmApi);
            if (!apiKey.Equals(extractedApiKey))
            {
                context.Response.StatusCode = 808;
                await context.Response.WriteAsync("Unauthorized client");
                return;
            }
            await _next(context);
        }
    }
}
