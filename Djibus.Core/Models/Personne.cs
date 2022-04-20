using Djibus.Core.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class Personne : CommonProperty
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
    }
}
