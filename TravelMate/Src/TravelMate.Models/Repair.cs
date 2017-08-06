using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the repairs table.
	/// </summary>
	[Table("repairs")]
	public partial class Repair
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int vehicleid { get; set; }
		public virtual int repairtypeId { get; set; }
		public virtual string details { get; set; }
		public virtual string pvnumber { get; set; }
		public virtual double amount { get; set; }
		public virtual bool isestimated { get; set; }
		public virtual DateTime? repairdate { get; set; }
		public virtual DateTime returndate { get; set; }
		public virtual string remarks { get; set; }
		public virtual int? enteredby { get; set; }
		public virtual Vehicle vehicle { get; set; }
		public virtual Repairtype repairtype { get; set; }
		public virtual IEnumerable<Repairspayment> repairspayment { get; set; }
		public virtual IEnumerable<Issuedsparepart> issuedspareparts { get; set; }
	}
}