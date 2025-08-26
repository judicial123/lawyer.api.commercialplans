using System.Collections.Generic;

namespace lawyer.api.commercialplans.application.DTO;

public class CountryQueryDto : CountryDto
{
    public List<CityDto> Cities { get; set; } = new();
}
