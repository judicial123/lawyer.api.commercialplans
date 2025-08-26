using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.LegalTechPlan;

public class LegalTechPlanQueryRepository : QueryRepository<domain.LegalTechPlan, LegalTechPlanEntity>, ILegalTechPlanQueryRepository
{
    private readonly IMapper _mapper;

    public LegalTechPlanQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
