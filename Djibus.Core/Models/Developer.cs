using Djibus.Core.CommonEntities;
using System;
namespace Djibus.Core.Models
{
	public class Developer: CommonProperty
    {
		public Developer()
		{
		}

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public ICollection<Demande> Demandes { get; set; }
    }
}

