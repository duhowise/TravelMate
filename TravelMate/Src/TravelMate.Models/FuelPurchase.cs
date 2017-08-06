using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the fuelpurchase table.
	/// </summary>
	[Table("fuelpurchase")]
	public partial class Fuelpurchase
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int vehicleid { get; set; }
		public virtual DateTime date { get; set; }
		public virtual int driverid { get; set; }
		public virtual int fillingstationid { get; set; }
		public virtual int fueltypeid { get; set; }
		public virtual double costperlitre { get; set; }
		public virtual int litrespurchased { get; set; }
		public virtual double amount { get; set; }
		public virtual string odometerreading { get; set; }
		public virtual Vehicle vehicle { get; set; }
		public virtual Staff staff { get; set; }
		public virtual Company company { get; set; }
		public virtual Fuel fuel { get; set; }
	}
}