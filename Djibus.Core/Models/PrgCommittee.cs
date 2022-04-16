using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class PrgCommittee
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime DatePRG { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}
