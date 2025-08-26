using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Country;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Country.GetById;

public class GetByIdCountryQueryHandler : IRequestHandler<GetByIdCountryQuery, CountryQueryDto>
{
    private readonly IMapper _mapper;
    private readonly ICountryQueryRepository _query;

    public GetByIdCountryQueryHandler(
        IMapper mapper,
        ICountryQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<CountryQueryDto> Handle(GetByIdCountryQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id, "Cities");
        return _mapper.Map<CountryQueryDto>(entity);
    }
}
