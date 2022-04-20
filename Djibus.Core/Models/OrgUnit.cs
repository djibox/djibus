using Djibus.Core.CommonEntities;

namespace Djibus.Core.Models
{
    public class OrgUnit : CommonProperty
    {
        public int Id { get; set; }
        public string OrgUnitName { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}