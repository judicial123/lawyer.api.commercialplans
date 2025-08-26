using AutoMapper;
using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.Example.Create;
using lawyer.api.commercialplans.application.UseCases.Example.Update;
using lawyer.api.commercialplans.domain;

namespace lawyer.api.commercialplans.application.Common.MappingProfiles;

public class ExampleProfile : Profile
{
    public ExampleProfile()
    {
        CreateMap<ExampleDto, Example>().ReverseMap();
        CreateMap<CreateExampleCommand, Example>().ReverseMap();
        CreateMap<UpdateExampleCommand, Example>().ReverseMap();
    }
}
