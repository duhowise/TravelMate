using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the AccessLevel table.
	/// </summary>
	[Table("AccessLevel")]
	public  class AccessLevel
	{
		[Key]
		public  byte Id { get; set; }
		public  string Name { get; set; }
		public  IEnumerable<User> users { get; set; }
	}
}