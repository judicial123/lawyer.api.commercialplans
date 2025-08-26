using AutoMapper;
using lawyer.api.commercialplans.domain;
using lawyer.api.commercialplans.datastore.mssql.Model;

namespace lawyer.api.commercialplans.datastore.mssql.Model.MappingProfile;

public class ApplicationMappingProfile : Profile
{
    public ApplicationMappingProfile()
    {
        CreateMap<Example, ExampleEntity>().ReverseMap();
        CreateMap<City, CityEntity>().ReverseMap();
        CreateMap<Country, CountryEntity>().ReverseMap();
        CreateMap<MarketingPlan, MarketingPlanEntity>().ReverseMap();
    }
}
