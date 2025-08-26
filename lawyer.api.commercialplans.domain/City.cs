using lawyer.api.commercialplans.domain.Common;

namespace lawyer.api.commercialplans.domain;

public class City : BaseEntity
{
    public Guid IdCountry { get; set; }
    public string Name { get; set; } = string.Empty;
}
