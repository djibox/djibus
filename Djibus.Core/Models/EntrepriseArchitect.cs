using Djibus.Core.CommonEntities;
using System;
namespace Djibus.Core.Models
{
	public class EntrepriseArchitect : CommonProperty
	{
		public EntrepriseArchitect()
		{
		}
		public int Id { get; set; }
		public string FullName { get; set; }
		public string Email { get; set; }
		public ICollection<Demande> Demandes { get; set; }
	}
}