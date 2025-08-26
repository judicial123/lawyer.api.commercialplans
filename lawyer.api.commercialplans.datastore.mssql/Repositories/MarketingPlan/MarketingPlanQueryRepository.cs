using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.MarketingPlan;

public class MarketingPlanQueryRepository : QueryRepository<domain.MarketingPlan, MarketingPlanEntity>, IMarketingPlanQueryRepository
{
    private readonly IMapper _mapper;

    public MarketingPlanQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
