using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.commercialplans.datastore.mssql.Model.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Model;

[Table("Examples", Schema = "commercialplans")]
public class ExampleEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
