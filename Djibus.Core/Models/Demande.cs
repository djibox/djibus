using Djibus.Core.CommonEntities;
using System.ComponentModel.DataAnnotations;

namespace Djibus.Core.Models
{
    public class Demande : CommonProperty
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a Title")]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter a Type")]
        public int TypeDemandeId { get; set; }
        public TypeDemande TypeDemande { get; set; }
        public string? Sponsor { get; set; }
        public string? Contact { get; set; }
        public int? OrgUnitId { get; set; }
        public OrgUnit OrgUnit { get; set; }
        public DateTime? StartDate { get; set; }
        public bool? IsRequestTimeSensitive { get; set; }
        [DataType(DataType.MultilineText)]
        public string? BusinessNeed { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Benefits { get; set; }
        [DataType(DataType.MultilineText)]
        public string? ExpectedDeliverables { get; set; }
        public long? NumberOfPotentialUsers { get; set; }
        public bool? IsServiceRequestUnique { get; set; }
        [DataType(DataType.MultilineText)]
        public string? ImpactOfNotDoingIt { get; set; }
        public string? PotentialSolution { get; set; }
        public string? DependenciesIfAny  { get; set; }
        public int? PrgCommitteeId { get; set; }
        public PrgCommittee PrgCommittee { get; set; }
        public int? ArdaCommitteeId { get; set; }
        public ArdaCommittee ArdaCommittee { get; set; }
        public int? DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public int? BusinessAnalystId { get; set; }
        public BusinessAnalyst BusinessAnalyst { get; set; }
        public int? EntrepriseArchitectId { get; set; }
        public EntrepriseArchitect EntrepriseArchitect { get; set; }
        public IEnumerable<Activity> Activities { get; set; }


    }
}