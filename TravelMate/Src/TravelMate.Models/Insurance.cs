using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Insurance table.
	/// </summary>
	[Table("Insurance")]
	public  class Insurance
	{
		[Key]
		public  int ID { get; set; }
		public  int? VehicleId { get; set; }
		public  string PolicyNo { get; set; }
		public  string Com { get; set; }
		public  int? Type { get; set; }
		public  decimal? Cost { get; set; }
		public  DateTime? IssueDate { get; set; }
		public  DateTime? ExpiryDate { get; set; }
		public  string Remarks { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  InsuranceType InsuranceType { get; set; }
	}
}