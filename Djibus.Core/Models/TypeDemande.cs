using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class TypeDemande
    {
        public int Id { get; set; }
        public string DemandeTypeName { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}
