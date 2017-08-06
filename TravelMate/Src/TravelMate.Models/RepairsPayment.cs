using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the repairspayment table.
	/// </summary>
	[Table("repairspayment")]
	public partial class Repairspayment
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int? pvcount { get; set; }
		public virtual int repairid { get; set; }
		public virtual string pvnumber { get; set; }
		public virtual double amount { get; set; }
		public virtual bool paid { get; set; }
		public virtual string chequenumber { get; set; }
		public virtual DateTime? chequedate { get; set; }
		public virtual Repair repair { get; set; }
	}
}