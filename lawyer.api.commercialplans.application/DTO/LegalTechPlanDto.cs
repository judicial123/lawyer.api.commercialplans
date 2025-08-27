namespace lawyer.api.commercialplans.application.DTO;

public class LegalTechPlanDto
{
    public Guid Id { get; set; }
    public Guid IdLawFirm { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Used { get; set; }
    public decimal Price { get; set; }
}
