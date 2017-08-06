using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the licensetype table.
	/// </summary>
	[Table("licensetype")]
	public partial class Licensetype
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<License> license { get; set; }
	}
}