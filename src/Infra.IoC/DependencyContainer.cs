using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped(typeof(ICourseService), typeof(CourseService));

            // Infra.Data Layer
            services.AddScoped(typeof(ICourseRepository), typeof(CourseRepository));
        }
    }
}