using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.City.GetAll;

public class GetAllCityQuery : IRequest<List<CityDto>>, IRequest<CityDto>
{
}
