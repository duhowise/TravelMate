using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the FuelPurchase table.
	/// </summary>
	[Table("FuelPurchase")]
	public  class FuelPurchase
	{
		[Key]
		public  int Id { get; set; }
		public  int VehicleId { get; set; }
		public  DateTime Date { get; set; }
		public  int DriverId { get; set; }
		public  int FillingStationId { get; set; }
		public  int FuelTypeId { get; set; }
		public  decimal CostPerLitre { get; set; }
		public  int LitresPurchased { get; set; }
		public  decimal Amount { get; set; }
		public  string OdometerRead { get; set; }
		public  Vehicle Vehicle { get; set; }
		public  Staff Staff { get; set; }
		public  Company Company { get; set; }
		public  Fuel Fuel { get; set; }
	}
}