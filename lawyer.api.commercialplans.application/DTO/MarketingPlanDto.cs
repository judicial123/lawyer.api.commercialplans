namespace lawyer.api.commercialplans.application.DTO;

public class MarketingPlanDto
{
    public Guid Id { get; set; }
    public Guid IdLawFirm { get; set; }
    public DateTime EntryDate { get; set; }
    public int ContactsNumber { get; set; }
    public int ContactsUsed { get; set; }
    public decimal Price { get; set; }
}
