using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.City;

public class CityQueryRepository : QueryRepository<domain.City, CityEntity>, ICityQueryRepository
{
    private readonly IMapper _mapper;

    public CityQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
