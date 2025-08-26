using AutoMapper;
using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.Country.Create;
using lawyer.api.commercialplans.application.UseCases.Country.Update;
using lawyer.api.commercialplans.domain;

namespace lawyer.api.commercialplans.application.Common.MappingProfiles;

public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<CountryDto, Country>().ReverseMap();
        CreateMap<CountryQueryDto, Country>().ReverseMap();
        CreateMap<CreateCountryCommand, Country>().ReverseMap();
        CreateMap<UpdateCountryCommand, Country>().ReverseMap();
    }
}
