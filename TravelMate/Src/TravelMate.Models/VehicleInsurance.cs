using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the VehicleInsurance table.
	/// </summary>
	[Table("VehicleInsurance")]
	public  class VehicleInsurance
	{
		[Key]
		public  int Id { get; set; }
		public  int Vehicleid { get; set; }
		public  int InsuranceId { get; set; }
		public  int? IssuerId { get; set; }
		public  int InsuranceTypeId { get; set; }
		public  string Remarks { get; set; }
		public  DateTime? date { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  Company Company { get; set; }
		public  InsuranceType InsuranceType { get; set; }
	}
}