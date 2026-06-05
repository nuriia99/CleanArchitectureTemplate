using Scalar.AspNetCore;

namespace CleanArchitectureTemplate.Extensions
{
    public static class OpenApiExtensions
    {
        public static IServiceCollection AddOpenApiDocumentation(this IServiceCollection services)
        {
            services.AddOpenApi();
            return services;
        }

        public static IEndpointRouteBuilder MapOpenApiDocumentation(this IEndpointRouteBuilder app)
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.Theme = ScalarTheme.Solarized;
            });
            return app;
        }
    }
}
