using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Faculty table.
	/// </summary>
	[Table("Faculty")]
	public  class Faculty
	{
		[Key]
		public  int ID { get; set; }
		public  string Name { get; set; }
		public  IEnumerable<Department> Department { get; set; }
	}
}