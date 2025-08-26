using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Country.GetAll;

public class GetAllCountryQuery : IRequest<List<CountryQueryDto>>, IRequest<CountryQueryDto>
{
}
