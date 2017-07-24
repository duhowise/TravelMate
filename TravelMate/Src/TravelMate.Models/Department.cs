using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Department table.
	/// </summary>
	[Table("Department")]
	public  class Department
	{
		[Key]
		public  int ID { get; set; }
		public  string Name { get; set; }
		public  int? FacultyId { get; set; }
		public  Faculty Faculty { get; set; }
		public  IEnumerable<GatePass> GatePass { get; set; }
	}
}