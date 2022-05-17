using Djibus.Core.CommonEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djibus.Core.Models
{
    public class UserMandatory:CommonProperty
    {
        public int Id { get; set; }
        public int ProfileUserId { get; set; }
        public ProfileUser ProfileUser { get; set; }
        public string UserName { get; set; }
    }
}
