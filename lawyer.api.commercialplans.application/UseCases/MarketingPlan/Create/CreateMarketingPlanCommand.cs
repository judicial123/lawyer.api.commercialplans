using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Create;

public class CreateMarketingPlanCommand : IRequest<Guid>
{
    public Guid IdLawFirm { get; set; }
    public DateTime EntryDate { get; set; }
    public int ContactsNumber { get; set; }
    public int ContactsUsed { get; set; }
    public decimal Price { get; set; }
}
