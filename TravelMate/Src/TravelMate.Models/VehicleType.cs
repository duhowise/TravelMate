using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the VehicleType table.
	/// </summary>
	[Table("VehicleType")]
	public  class VehicleType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<Vehicle> Vehicle { get; set; }
	}

}