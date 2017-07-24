using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the LicenseType table.
	/// </summary>
	[Table("LicenseType")]
	public  class LicenseType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<License> License { get; set; }
	}
}