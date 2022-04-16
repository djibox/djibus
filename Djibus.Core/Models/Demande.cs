using System.ComponentModel.DataAnnotations;

namespace Djibus.Core.Models
{
    public class Demande
    {
        public int Id { get; set; }
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
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
    }
}