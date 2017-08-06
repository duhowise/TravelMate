using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the tyretype table.
	/// </summary>
	[Table("tyretype")]
	public partial class Tyretype
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<Vehicle> vehicle { get; set; }
		
	}
}