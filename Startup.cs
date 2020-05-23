using HotChocolate;
using HotChocolate.AspNetCore;
using learnhotchocolate.Data;
using learnhotchocolate.Schema;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace learnhotchocolate
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LearnHotChocolateContext>(options =>
            {
                options
                .UseNpgsql("Host=127.0.0.1;Database=learnchocodb;Port=5432;UserId=postgres;Password=testpass");
            });
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(p =>
                {
                    p.WithOrigins("http://localhost:8080")
                     .AllowAnyHeader().AllowAnyOrigin()
                     .AllowAnyMethod();
                });
            });
            services.AddGraphQL(
                SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .Create()
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
            .UseCors()
            .UseRouting();
            app
            .UseWebSockets()
            .UseGraphQL()
            .UsePlayground();
        }
    }
}
