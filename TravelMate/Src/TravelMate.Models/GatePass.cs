using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the gatepass table.
	/// </summary>
	[Table("gatepass")]
	public partial class Gatepass
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int departmentid { get; set; }
		public virtual string passcode { get; set; }
		public virtual int vehicleid { get; set; }
		public virtual int driverid { get; set; }
		public virtual DateTime dateissued { get; set; }
		public virtual string destination { get; set; }
		public virtual string purpose { get; set; }
		public virtual bool approved { get; set; }
		public virtual int approvedby { get; set; }
		public virtual DateTime checkouttime { get; set; }
		public virtual DateTime returndate { get; set; }
		public virtual string remarks { get; set; }
		public virtual Department department { get; set; }
		public virtual Vehicle vehicle { get; set; }
		public virtual Staff staff { get; set; }
	}
}