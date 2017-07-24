using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the IssuedSpareParts table.
	/// </summary>
	[Table("IssuedSpareParts")]
	public  class IssuedSparePart
	{
		[Key]
		public  int Id { get; set; }
		public  int SparePartId { get; set; }
		public  int? RepairId { get; set; }
		public  int QuantityUsed { get; set; }
		public  DateTime DateIssued { get; set; }
		public  SparePart SparePart { get; set; }
		public  Repair Repair { get; set; }
	}
}