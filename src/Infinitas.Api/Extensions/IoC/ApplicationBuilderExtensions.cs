using Microsoft.AspNetCore.Builder;

namespace Infinitas.Api
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseApplicationServices(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enrolments API");
                c.RoutePrefix = string.Empty;
            });

            return app;
        }
    }
}
