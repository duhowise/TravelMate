using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the TyreType table.
	/// </summary>
	[Table("TyreType")]
	public  class TyreType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<Vehicle> Vehicles { get; set; }
		
	}
}