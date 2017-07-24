using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the VehicleTranmission table.
	/// </summary>
	[Table("VehicleTranmission")]
	public  class VehicleTranmission
	{
		[Key]
		public  int Id { get; set; }
		public  string Name { get; set; }
		public  IEnumerable<Vehicle> Vehicle { get; set; }
	}
}