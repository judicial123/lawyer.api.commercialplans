namespace lawyer.api.commercialplans.application.DTO;

public class CityDto
{
    public Guid Id { get; set; }
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
