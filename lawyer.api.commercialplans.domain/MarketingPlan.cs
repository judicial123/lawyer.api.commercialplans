using lawyer.api.commercialplans.domain.Common;

namespace lawyer.api.commercialplans.domain;

public class MarketingPlan : BaseEntity
{
    public Guid IdLawFirm { get; set; }
    public DateTime EntryDate { get; set; }
    public int ContactsNumber { get; set; }
    public int ContactsUsed { get; set; }
    public decimal Price { get; set; }
}
