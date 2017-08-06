using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the vehicletype table.
	/// </summary>
	[Table("vehicletype")]
	public partial class Vehicletype
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<Vehicle> vehicle { get; set; }
	}
}