using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the RepairsPayment table.
	/// </summary>
	[Table("RepairsPayment")]
	public  class RepairsPayment
	{
		[Key]
		public  int Id { get; set; }
		public  int? PVCount { get; set; }
		public  int RepairId { get; set; }
		public  string PVNumber { get; set; }
		public  decimal Amount { get; set; }
		public  bool Paid { get; set; }
		public  string ChequeNumber { get; set; }
		public  DateTime? ChequeDate { get; set; }
		public  Repair Repair { get; set; }
	}
}