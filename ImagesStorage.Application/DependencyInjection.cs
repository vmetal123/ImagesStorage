﻿using ImagesStorage.Application.Interfaces.UseCases;
using ImagesStorage.Application.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImagesStorage.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRegisterUserUseCase, RegisterUserUseCase>();
            services.AddScoped<IGetUserByUserNameUseCase, GetUserByUserNameUseCase>();
            services.AddScoped<IGetUsersUseCase, GetUsersUseCase>();

            return services;
        }
    }
}
