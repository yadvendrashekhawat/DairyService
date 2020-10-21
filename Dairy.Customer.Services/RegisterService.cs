using Dairy.Customer.Services.Implementation;
using Dairy.Customer.Services.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Dairy.Customer.Services
{
    public static class RegisterService
    {
        public static IServiceCollection RegisterReportServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            return services;
        }
    }
}
