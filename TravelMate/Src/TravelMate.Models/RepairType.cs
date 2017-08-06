using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the repairtype table.
	/// </summary>
	[Table("repairtype")]
	public partial class Repairtype
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual IEnumerable<Repair> repairs { get; set; }
	}
}