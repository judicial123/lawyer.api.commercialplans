using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Example.GetById;

public class GetByIdExampleQuery : IRequest<ExampleDto>
{
    public GetByIdExampleQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
