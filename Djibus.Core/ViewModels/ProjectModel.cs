using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.ViewModels
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string? PM { get; set; }
        public string? Customer { get; set; }
        public string? Beneficiary { get; set; }
        public string? Projects { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public string? RessourceChis1 { get; set; }
        public string? ApprovedBudget { get; set; }
        public string? AllotedBudget { get; set; }
        public string? AvailableBudget { get; set; }
        public string? Effort { get; set; }
        public string? PlannedStartDate { get; set; }
        public string? PlannedEndDate { get; set; }
        public string? ExpectedEndDate { get; set; }
        public string? ActualEndDate { get; set; }
        public string? ActualStartDate { get; set; }
        public string? Status { get; set; }
        public string? PourcentageAchievement { get; set; }
        public string? ChallengesOrSolutions { get; set; }
        public string? ProjectStage { get; set; }
        public string? ThemeStrategy { get; set; }
        public string? ChangeManNeeded { get; set; }
        public string? ProjectsVendorExternalRessources { get; set; }
        public string? ProjectsGovernanceIssue { get; set; }
        public string? projectUsersAvailabilityIssue { get; set; }
        public string? projectStaffingRessourcesIssues { get; set; }
        public string? ProjectsRessourcesWithMultiplesAssignement { get; set; }
        public string? ProjectProcurementIssues { get; set; }
        public string? ProjectDeliveryDelay { get; set; }
        public string? Comments { get; set; }
    }
}
