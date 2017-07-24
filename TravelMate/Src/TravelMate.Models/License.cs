using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the License table.
	/// </summary>
	[Table("License")]
	public  class License
	{
		[Key]
		public  int id { get; set; }
		public  int StaffId { get; set; }
		public  int typeId { get; set; }
		public  string LicenseNo { get; set; }
		public  bool? Temporary { get; set; }
		public  DateTime Issued { get; set; }
		public  DateTime Expiry { get; set; }
		public  Staff Staff { get; set; }
		public  LicenseType LicenseType { get; set; }
	}
}