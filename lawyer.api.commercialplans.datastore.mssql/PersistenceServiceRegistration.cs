using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model.MappingProfile;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Example;
using lawyer.api.commercialplans.datastore.mssql.Repositories.MarketingPlan;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lawyer.api.commercialplans.datastore.mssql;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<LawyersContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LawyersConnectionString")));
        services.AddAutoMapper(typeof(ApplicationMappingProfile).Assembly);
        services.AddScoped<IExampleCommandRepository, ExampleCommandRepository>();
        services.AddScoped<IExampleQueryRepository, ExampleQueryRepository>();
        services.AddScoped<IMarketingPlanCommandRepository, MarketingPlanCommandRepository>();
        services.AddScoped<IMarketingPlanQueryRepository, MarketingPlanQueryRepository>();

        return services;
    }
}