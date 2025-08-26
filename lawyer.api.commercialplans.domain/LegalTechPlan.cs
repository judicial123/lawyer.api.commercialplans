using lawyer.api.commercialplans.domain.Common;

namespace lawyer.api.commercialplans.domain;

public class LegalTechPlan : BaseEntity
{
    public Guid IdLawFirm { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Used { get; set; }
    public decimal Price { get; set; }
}
