using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the expense table.
	/// </summary>
	[Table("expense")]
	public partial class Expense
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int vehicleid { get; set; }
		public virtual string servicedescription { get; set; }
		public virtual DateTime? servicedate { get; set; }
		public virtual double? mileage { get; set; }
		public virtual bool actual { get; set; }
		public virtual bool estimate { get; set; }
		public virtual double cost { get; set; }
		public virtual int shopid { get; set; }
		public virtual string invoicenumber { get; set; }
		public virtual string warrantynumber { get; set; }
		public virtual string notes { get; set; }
		public virtual string imageurl { get; set; }
		public virtual Vehicle vehicle { get; set; }
	}
}