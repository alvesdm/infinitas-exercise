using Infinitas.Application;
using Infinitas.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;

namespace Infinitas.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServicesContainer(this IServiceCollection services)
        {
            services.AddData();
            services.AddApplication();
            services.AddPresentation();

            return services;
        }

        public static IServiceCollection AddData(this IServiceCollection services)
        {
            services.AddSingleton<IAmDbContext, DapperContext>();
            services.AddSingleton<IAmEnrolmentRepository, EnrolmentRepository>();

            return services;
        }

        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IAmEnrolmentService, EnrolmentService>();

            return services;
        }

        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            services.AddMediatR(typeof(Startup));

            return services;
        }
    }
}
