using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.City;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.City;

public class CityCommandRepository : CommandRepository<domain.City, CityEntity>, ICityCommandRepository
{
    private readonly IMapper _mapper;

    public CityCommandRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
