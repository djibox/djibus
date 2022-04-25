using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PM { get; set; }
        public string? Customer { get; set; }
        public string? Beneficiary { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? RessourceChis1 { get; set; }
        public double ApprovedBudget { get; set; }
        public double AllotedBudget { get; set; }
        public double AvailableBudget { get; set; }
        public int Effort { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PlannedStartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PlannedEndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ExpectedEndDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ActualStartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ActualEndDate { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Status { get; set; }
        public int PourcentageAchievement { get; set; }
        [DataType(DataType.MultilineText)]
        public string? ChallengesOrSolutions { get; set; }
        public string? ProjectStage { get; set; }
        public string? ThemeStrategy { get; set; }
        public bool ChangeManNeeded { get; set; }
        public bool ProjectsVendorExternalRessources { get; set; }
        public bool ProjectsGovernanceIssue { get; set; }
        public bool projectUsersAvailabilityIssue { get; set; }
        public bool projectStaffingRessourcesIssues { get; set; }
        public bool ProjectsRessourcesWithMultiplesAssignement { get; set; }
        public bool ProjectProcurementIssues { get; set; }
        public bool ProjectDeliveryDelay { get; set; }
        [DataType(DataType.MultilineText)]
        public string? Comments { get; set; }


    }
}
