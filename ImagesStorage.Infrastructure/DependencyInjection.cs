using AspNetCore.Identity.MongoDbCore.Models;
using AutoMapper;
using ImagesStorage.Application.Config;
using ImagesStorage.Application.Interfaces.Repositories;
using ImagesStorage.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ImagesStorage.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var mongoSettings = configuration.GetSection(nameof(MongoDbSettings));
            var settings = configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();

            services.AddSingleton<MongoDbSettings>(settings);

            services.AddIdentity<ApplicationUser, MongoIdentityRole>()
                .AddMongoDbStores<ApplicationUser, MongoIdentityRole, Guid>(settings.ConnectionString, settings.DatabaseName)
                .AddDefaultTokenProviders();

            services.Configure<MongoDbSettings>(mongoSettings);

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
