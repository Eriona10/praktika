using Microsoft.AspNetCore.Builder;
using Ocelot.Values;
using Pet.Microservice.Interfaces;
using Pet.Microservice.Services;

namespace Pet.Microservice
{
    public class Startup
    {
        /*
        public void Configure(IApplicationBuilder app)
        {
            services.AddTransient<IPetService, PetService>();
        }
        */


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPetService, PetService>();

        }
    }
}
