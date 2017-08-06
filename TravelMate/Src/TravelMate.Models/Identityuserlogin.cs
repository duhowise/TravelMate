using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the identityuserlogins table.
	/// </summary>
	[Table("identityuserlogins")]
	public partial class Identityuserlogin
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual int UserID { get; set; }
		public virtual string LoginProvider { get; set; }
		public virtual string ProviderKey { get; set; }
		public virtual Identityuser identityuser { get; set; }
	}
}