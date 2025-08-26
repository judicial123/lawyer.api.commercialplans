using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.commercialplans.datastore.mssql.Model.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Model;

[Table("Countries", Schema = "commercialplans")]
public class CountryEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string Name { get; set; }

    public ICollection<CityEntity> Cities { get; set; } = new List<CityEntity>();
}
