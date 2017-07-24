using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the CompanyType table.
	/// </summary>
	[Table("CompanyType")]
	public  class CompanyType
	{
		[Key]
		public  int Id { get; set; }
		public  string name { get; set; }
		public  IEnumerable<Company> Company { get; set; }
	}
}