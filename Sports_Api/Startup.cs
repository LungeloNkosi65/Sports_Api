using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Sports_Api.Repository;
using Sports_Api.Services;

namespace Sports_Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddControllers();
            services.AddDbContext<HollywoodBetsRepDbContext>(options =>
                             options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });

            //services.AddControllers().AddNewtonsoftJson(options =>
            //options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore
            //);
            services.AddScoped<ISportRepository, SportRepository>();
            services.AddScoped<ISportService, SportService>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ITournamentRepository, TournamentRepository>();
            services.AddScoped<ITournamentService, TournamentService>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IBetTypeRepository, BetTypeRepository>();
            services.AddScoped<IBetTypeService, BetTypeService>();
            services.AddScoped<IMarketService, MarketService>();
            services.AddScoped<IMarketRepository, MarketRepository>();
            services.AddScoped<IOddsRepository, OddsRepository>();
            services.AddScoped<IOddsService, OddsService>();
            services.AddScoped<ISportCountryRepository, SportCountryRepository>();
            services.AddScoped<ISportCountryService, SportCountryService>();
            services.AddScoped<IBetRepository, BetRepository>();
            services.AddScoped<IBetService, BetService>();
            services.AddScoped<ISportTournamentRepository, SportTournamentRepository>();
            services.AddScoped<ISportTournamentService, SportTournamentService>();
            services.AddScoped<ITournamentBetTypeRepository, TournamentBetTypeRepository>();
            services.AddScoped<ITournamentBetTypeService, TournamentBetTypeService>();
            services.AddScoped<IOddsDefaultRepository, OddsDefaultRepository>();
            services.AddScoped<IOddsDefaultService, OddsDefaultService>();
            services.AddScoped<IBetTypeMarketRepository, BetTypeMarketRepository>();
            services.AddScoped<IBetTypeMarketService, BetTypeMarketService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            // Passing log configuration to log4net's config
            object p = loggerFactory.AddLog4Net();
          
        }
    }
}
