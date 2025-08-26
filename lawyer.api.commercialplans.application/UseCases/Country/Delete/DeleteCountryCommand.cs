using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Country.Delete;

public class DeleteCountryCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
