using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.Example.GetById;

public class GetByIdExampleQueryHandler : IRequestHandler<GetByIdExampleQuery, ExampleDto>
{
    private readonly IMapper _mapper;
    private readonly IExampleQueryRepository _query;

    public GetByIdExampleQueryHandler(
        IMapper mapper,
        IExampleQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<ExampleDto> Handle(GetByIdExampleQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<ExampleDto>(entity);
    }
}
