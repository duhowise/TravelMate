using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the GatePass table.
	/// </summary>
	[Table("GatePass")]
	public  class GatePass
	{
		[Key]
		public  int Id { get; set; }
		public  int Departmentid { get; set; }
		public  string PassCode { get; set; }
		public  int vehicleId { get; set; }
		public  int DriverId { get; set; }
		public  DateTime DateIssued { get; set; }
		public  string Destination { get; set; }
		public  string Purpose { get; set; }
		public  bool Approved { get; set; }
		public  int ApprovedBy { get; set; }
		public  DateTime CheckOutTime { get; set; }
		public  DateTime ReturnDate { get; set; }
		public  string Remarks { get; set; }
		public  Department Department { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  Staff Staff { get; set; }
	}
}