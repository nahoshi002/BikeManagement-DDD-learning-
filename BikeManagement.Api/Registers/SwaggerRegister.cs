using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using BikeManagement.Api.Options;

namespace BikeManagement.Api.Registers
{
    public class SwaggerRegister : IWebApplicationBuilderRegister
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();
        }
    }
}
