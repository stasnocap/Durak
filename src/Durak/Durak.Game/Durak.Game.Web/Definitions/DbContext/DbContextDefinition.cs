﻿using Calabonga.AspNetCore.AppDefinitions;
using Durak.Game.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Durak.Game.Web.Definitions.DbContext
{
    /// <summary>
    /// ASP.NET Core services registration and configurations
    /// </summary>
    public class DbContextDefinition : AppDefinition
    {
        /// <summary>
        /// Configure services for current microservice
        /// </summary>
        /// <param name="services"></param>
        /// <param name="builder"></param>
        public override void ConfigureServices(IServiceCollection services, WebApplicationBuilder builder)
            => services.AddDbContext<ApplicationDbContext>(config =>
            {
                // UseInMemoryDatabase - This for demo purposes only!
                // Should uninstall package "Microsoft.EntityFrameworkCore.InMemory" and install what you need. 
                // For example: "Microsoft.EntityFrameworkCore.SqlServer"
                // uncomment line below to use UseSqlServer(). Don't forget setup connection string in appSettings.json 
                config.UseInMemoryDatabase("DEMO_PURPOSES_ONLY");
                // config.UseSqlServer(configuration.GetConnectionString(nameof(ApplicationDbContext)));
            });
    }
}