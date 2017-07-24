using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Expense table.
	/// </summary>
	[Table("Expense")]
	public  class Expense
	{
		[Key]
		public  int ID { get; set; }
		public  int Vehicleid { get; set; }
		public  string ServiceDescription { get; set; }
		public  DateTime? ServiceDate { get; set; }
		public  double? Mileage { get; set; }
		public  bool Actual { get; set; }
		public  bool Estimate { get; set; }
		public  decimal Cost { get; set; }
		public  int ShopId { get; set; }
		public  string InvoiceNumber { get; set; }
		public  string WarrantyNumber { get; set; }
		public  string Notes { get; set; }
		public  byte[] Attachment { get; set; }
		public  Vehicle Vehicle { get; set; }
	}
}