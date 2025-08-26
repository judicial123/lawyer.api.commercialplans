using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.Country;

public class CountryCommandRepository : CommandRepository<domain.Country, CountryEntity>, ICountryCommandRepository
{
    private readonly IMapper _mapper;

    public CountryCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
