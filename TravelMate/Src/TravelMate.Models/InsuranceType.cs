using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the InsuranceType table.
	/// </summary>
	[Table("InsuranceType")]
	public  class InsuranceType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<VehicleInsurance> VehicleInsurance { get; set; }
		public  IEnumerable<Insurance> Insurance { get; set; }
	}
}