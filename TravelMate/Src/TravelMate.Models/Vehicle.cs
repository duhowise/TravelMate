using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Vehicle table.
	/// </summary>
	[Table("Vehicle")]
	public  class Vehicle
	{
		[Key]
		public  int Id { get; set; }
		public  string Make { get; set; }
		public  string Model { get; set; }
		public  int? Year { get; set; }
		public  string Color { get; set; }
		public  string VehicleNumber { get; set; }
		public  string VinNumber { get; set; }
		public  int TypeId { get; set; }
		public  DateTime PurchaseDate { get; set; }
		public  decimal PurchasePrice { get; set; }
		public  double? PurchaseMileage { get; set; }
		public  byte[] Attachments { get; set; }
		public  string Description { get; set; }
		public  string GrossWeight { get; set; }
		public  string EngineSize { get; set; }
		public  string EngineCapacity { get; set; }
		public  int FrontTyreType { get; set; }
		public  int? RearTyreType { get; set; }
		public  string State { get; set; }
		public  int? TransmissionType { get; set; }
		public  int? Batterytype { get; set; }
		public  int? Filtertype { get; set; }
		public  int? BatteryCount { get; set; }
		public  int? FilterCount { get; set; }
		public  int? FrontTyreCount { get; set; }
		public  int? RearTyreCount { get; set; }


		public  VehicleType VehicleType { get; set; }
		public  TyreType TyreType { get; set; }
		public  VehicleTranmission VehicleTranmission { get; set; }
		public  BatteryType BatteryType { get; set; }
		public  IEnumerable<LogBook> LogBook { get; set; }
		public  IEnumerable<Repair> Repairs { get; set; }
		public  IEnumerable<VehicleInsurance> VehicleInsurance { get; set; }
		public  IEnumerable<RoadWorthy> RoadWorthy { get; set; }
		public  IEnumerable<Expense> Expense { get; set; }
		public  IEnumerable<FuelPurchase> FuelPurchase { get; set; }
		public  IEnumerable<GatePass> GatePass { get; set; }
		public  IEnumerable<Insurance> Insurance { get; set; }
	}
}