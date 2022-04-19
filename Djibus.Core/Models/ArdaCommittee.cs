using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class ArdaCommittee
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime DateArda { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}
