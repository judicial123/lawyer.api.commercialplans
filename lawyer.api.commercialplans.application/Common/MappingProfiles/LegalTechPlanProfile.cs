using AutoMapper;
using lawyer.api.commercialplans.application.DTO;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Create;
using lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Update;
using lawyer.api.commercialplans.domain;

namespace lawyer.api.commercialplans.application.Common.MappingProfiles;

public class LegalTechPlanProfile : Profile
{
    public LegalTechPlanProfile()
    {
        CreateMap<LegalTechPlanDto, LegalTechPlan>().ReverseMap();
        CreateMap<CreateLegalTechPlanCommand, LegalTechPlan>().ReverseMap();
        CreateMap<UpdateLegalTechPlanCommand, LegalTechPlan>().ReverseMap();
    }
}
