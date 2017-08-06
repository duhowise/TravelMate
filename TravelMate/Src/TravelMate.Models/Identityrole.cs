using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the identityroles table.
	/// </summary>
	[Table("identityroles")]
	public partial class Identityrole
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual IEnumerable<Identityuserrole> identityuserroles { get; set; }
	}
}