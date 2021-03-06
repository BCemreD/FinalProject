using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities.IoC
{
    public static class ServiceTools
    {
 public static IServiceProvider serviceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            serviceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
