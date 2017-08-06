using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	///     A class which represents the batterytype table.
	/// </summary>
	[Table("batterytype")]
	public class Batterytype
	{
		[Key]
		public virtual int Id { get; set; }

		public virtual string Name { get; set; }
		public virtual IEnumerable<Vehicle> Vehicles { get; set; }
	}
}