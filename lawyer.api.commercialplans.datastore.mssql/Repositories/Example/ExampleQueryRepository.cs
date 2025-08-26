using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.commercialplans.datastore.mssql.DatabaseContext;
using lawyer.api.commercialplans.datastore.mssql.Model;
using lawyer.api.commercialplans.datastore.mssql.Repositories.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Repositories.Example;

public class ExampleQueryRepository : QueryRepository<domain.Example, ExampleEntity>, IExampleQueryRepository
{
    private readonly IMapper _mapper;

    public ExampleQueryRepository(LawyersContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
        _mapper = mapper;
    }
}
