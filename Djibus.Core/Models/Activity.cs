using Djibus.Core.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class Activity : CommonProperty
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? DemandeId { get; set; }
        public Demande Demande { get; set; }
        public DateTime ActivityDate { get; set; }
        public int Duration { get; set; }
    }
}
