using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.Country;

public class CountryQueryRepository : QueryRepository<domain.Country, CountryEntity>, ICountryQueryRepository
{
    private readonly IMapper _mapper;

    public CountryQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
