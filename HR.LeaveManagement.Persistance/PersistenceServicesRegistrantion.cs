﻿using HR.LeaveManagement.Application.Contracts.Persistence;
using HR.LeaveManagement.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Persistance
{
    public static class PersistenceServicesRegistrantion
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HrLeaveManagementDbContext>(options => 
            {
                options.UseSqlServer(configuration.GetConnectionString("LeaveManagementConnectionString"));

                services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));

                services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
                services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
                services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            });
            return services;
        }
    }
}
