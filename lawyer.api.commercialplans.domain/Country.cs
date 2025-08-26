using System.Collections.Generic;
using lawyer.api.commercialplans.domain.Common;

namespace lawyer.api.commercialplans.domain;

public class Country : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public List<City> Cities { get; set; } = new();
}
