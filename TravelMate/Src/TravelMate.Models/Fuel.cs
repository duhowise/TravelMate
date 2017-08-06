using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the fuel table.
	/// </summary>
	[Table("fuel")]
	public partial class Fuel
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<Fuelpurchase> fuelpurchase { get; set; }
	}
}