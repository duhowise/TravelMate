using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the LogBook table.
	/// </summary>
	[Table("LogBook")]
	public  class LogBook
	{
		[Key]
		public  int Id { get; set; }
		public  int VehicleId { get; set; }
		public  int DriverId { get; set; }
		public  string Purpose { get; set; }
		public  string StartLocation { get; set; }
		public  string Destination { get; set; }
		public  DateTime TimeStarted { get; set; }
		public  DateTime TimeArrived { get; set; }
		public  int? StartSpeed { get; set; }
		public  int? FinishSpeed { get; set; }
		public  int FuelUsed { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  Staff Staff { get; set; }
	}
}