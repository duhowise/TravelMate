using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the identityuserclaims table.
	/// </summary>
	[Table("identityuserclaims")]
	public partial class Identityuserclaim
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual int UserID { get; set; }
		public virtual string ClaimType { get; set; }
		public virtual string ClaimValue { get; set; }
		public virtual Identityuser identityuser { get; set; }
	}
}