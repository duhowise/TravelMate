using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Company table.
	/// </summary>
	[Table("Company")]
	public  class Company
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  int? ContactPerson { get; set; }
		public  string Mobile { get; set; }
		public  string Address { get; set; }
		public  int CompanyTypeId { get; set; }
		public  CompanyType CompanyType { get; set; }
		public  IEnumerable<FuelPurchase> FuelPurchase { get; set; }
		public  IEnumerable<VehicleInsurance> VehicleInsurance { get; set; }
	}
}