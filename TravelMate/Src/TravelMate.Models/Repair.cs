using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Repairs table.
	/// </summary>
	[Table("Repairs")]
	public  class Repair
	{
		[Key]
		public  int Id { get; set; }
		public  int VehicleId { get; set; }
		public  int RepairTypeId { get; set; }
		public  string Details { get; set; }
		public  string PVNumber { get; set; }
		public  decimal Amount { get; set; }
		public  bool IsEstimated { get; set; }
		public  DateTime? RepairDate { get; set; }
		public  DateTime ReturnDate { get; set; }
		public  string Remarks { get; set; }
		public  int? EnteredBy { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  RepairType RepairType { get; set; }
		public  IEnumerable<IssuedSparePart> IssuedSpareParts { get; set; }
		public  IEnumerable<RepairsPayment> RepairsPayment { get; set; }
	}
}