using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Update;

public class UpdateMarketingPlanCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid IdLawFirm { get; set; }
    public DateTime EntryDate { get; set; }
    public int ContactsNumber { get; set; }
    public int ContactsUsed { get; set; }
    public decimal Price { get; set; }
}
