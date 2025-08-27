using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.commercialplans.datastore.mssql.Model.Common;

namespace lawyer.api.commercialplans.datastore.mssql.Model;

[Table("LegalTechPlans", Schema = "commercialplans")]
public class LegalTechPlanEntity : EFEntity
{
    public Guid IdLawFirm { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Used { get; set; }
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}
