using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the RepairType table.
	/// </summary>
	[Table("RepairType")]
	public  class RepairType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<Repair> Repairs { get; set; }
	}
}