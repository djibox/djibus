namespace Djibus.Core.Models
{
    public class OrgUnit
    {
        public int Id { get; set; }
        public string OrgUnitName { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}