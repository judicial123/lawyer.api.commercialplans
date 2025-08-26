using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Country.GetById;

public class GetByIdCountryQuery : IRequest<CountryQueryDto>
{
    public GetByIdCountryQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
