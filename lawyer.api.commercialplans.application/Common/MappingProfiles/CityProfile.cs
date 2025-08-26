using AutoMapper;
using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.City.Create;
using lawyer.api.commercialplans.application.UseCases.City.Update;
using lawyer.api.commercialplans.domain;

namespace lawyer.api.commercialplans.application.Common.MappingProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<CityDto, City>().ReverseMap();
        CreateMap<CreateCityCommand, City>().ReverseMap();
        CreateMap<UpdateCityCommand, City>().ReverseMap();
    }
}
