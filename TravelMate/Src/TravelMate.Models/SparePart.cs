using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the SpareParts table.
	/// </summary>
	[Table("SpareParts")]
	public  class SparePart
	{
		[Key]
		public  int Id { get; set; }
		public  string Name { get; set; }
		public  string Description { get; set; }
		public  int Quantity { get; set; }
		public  IEnumerable<IssuedSparePart> IssuedSpareParts { get; set; }
	}
}