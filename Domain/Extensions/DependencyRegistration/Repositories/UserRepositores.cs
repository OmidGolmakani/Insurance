using Domain.Interfaces.Fundamentals.Repository;
using Domain.Interfaces.Globals.Repositories;
using Domain.Models.Dtos.Requests.Users;
using Domain.Models.Dtos.Responses.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extensions.DependencyRegistration.Repositories
{
    public static class UserRepositories
    {
        public static IServiceCollection AddUserRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<long, Models.Entities.User, GetUserRequest, GetUsersRequest, UserResponse>, Domain.Repositories.UserRepository>();
            services.AddScoped<IUserRepository, Domain.Repositories.UserRepository>();
            return services;
        }
    }
}
