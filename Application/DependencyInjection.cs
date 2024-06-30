using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using LeadsManagement.Application.Interfaces;
using LeadsManagement.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace LeadsManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddFluentValidationAutoValidation();

            return services;
        }
    }
}