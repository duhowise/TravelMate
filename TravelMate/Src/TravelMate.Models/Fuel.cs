using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Fuel table.
	/// </summary>
	[Table("Fuel")]
	public  class Fuel
	{
		[Key]
		public  int Id { get; set; }
		public  string Name { get; set; }
		public  IEnumerable<FuelPurchase> FuelPurchase { get; set; }
	}
}