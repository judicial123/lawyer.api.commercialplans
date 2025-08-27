using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.commercialplans.datastore.mssql.Model.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Model;

[Table("MarketingPlans", Schema = "commercialplans")]
public class MarketingPlanEntity : EFEntity
{
    public Guid IdLawFirm { get; set; }
    public DateTime EntryDate { get; set; }
    public int ContactsNumber { get; set; }
    public int ContactsUsed { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}
