using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the StaffDesignation table.
	/// </summary>
	[Table("StaffDesignation")]
	public  class StaffDesignation
	{
		[Key]
		public  int Id { get; set; }
		public  string Name { get; set; }
		public  IEnumerable<Staff> Staff { get; set; }
	}
}