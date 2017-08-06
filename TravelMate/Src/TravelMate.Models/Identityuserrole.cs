using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the identityuserroles table.
	/// </summary>
	[Table("identityuserroles")]
	public partial class Identityuserrole
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual int UserId { get; set; }
		public virtual int RoleId { get; set; }
		public virtual Identityuser identityuser { get; set; }
		public virtual Identityrole identityrole { get; set; }
	}
}