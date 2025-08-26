using AutoMapper;
using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.Create;
using lawyer.api.commercialplans.application.UseCases.MarketingPlan.Update;
using lawyer.api.commercialplans.domain;

namespace lawyer.api.commercialplans.application.Common.MappingProfiles;

public class MarketingPlanProfile : Profile
{
    public MarketingPlanProfile()
    {
        CreateMap<MarketingPlanDto, MarketingPlan>().ReverseMap();
        CreateMap<CreateMarketingPlanCommand, MarketingPlan>().ReverseMap();
        CreateMap<UpdateMarketingPlanCommand, MarketingPlan>().ReverseMap();
    }
}
