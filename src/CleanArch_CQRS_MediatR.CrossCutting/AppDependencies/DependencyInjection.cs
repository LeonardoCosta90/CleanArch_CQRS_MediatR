using CleanArch_CQRS_MediatR.Domain.Abstractions;
using CleanArch_CQRS_MediatR.Infrastructure.Context;
using CleanArch_CQRS_MediatR.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySqlConnector;
using System.Data;

namespace CleanArch_CQRS_MediatR.CrossCutting.AppDependencies;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
                  this IServiceCollection services,
                  IConfiguration configuration)
    {
        var mySqlConnection = configuration
                              .GetConnectionString("DefaultConnection");

        services.AddDbContext<AppDbContext>(options =>
                         options.UseMySql(mySqlConnection,
                         ServerVersion.AutoDetect(mySqlConnection)));

        services.AddScoped<IMemberRepository,MemberRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        var myhandlers = AppDomain.CurrentDomain.Load("CleanArch_CQRS_MediatR.Application");
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(myhandlers));

        return services;
    }
}