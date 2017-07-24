using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the RoadWorthy table.
	/// </summary>
	[Table("RoadWorthy")]
	public  class RoadWorthy
	{
		[Key]
		public  int Id { get; set; }
		public  int? VehicleId { get; set; }
		public  DateTime? IssueDate { get; set; }
		public  DateTime? RenewalDate { get; set; }
		public  int? DriverId { get; set; }
		public  Vehicle Vehicle { get; set; }
	}
}