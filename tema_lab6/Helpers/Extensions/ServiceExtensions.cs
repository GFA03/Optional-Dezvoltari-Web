﻿using tema_lab4.Helpers.Seeders;
using tema_lab4.Repositories.UserRepository;
using tema_lab4.Services.UserService;

namespace tema_lab4.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<UsersSeeder>();

            return services;
        }
    }
}
