using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.City.Update;

public class UpdateCityCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
