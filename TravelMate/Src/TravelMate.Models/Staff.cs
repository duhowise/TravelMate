using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the staff table.
	/// </summary>
	[Table("staff")]
	public partial class Staff
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string firstname { get; set; }
		public virtual string lastname { get; set; }
		public virtual int staffdesignationid { get; set; }
		public virtual DateTime employmentdate { get; set; }
		public virtual int createdby { get; set; }
		public virtual Staffdesignation staffdesignation { get; set; }
		public virtual IEnumerable<Gatepass> gatepass { get; set; }
		public virtual IEnumerable<License> license { get; set; }
		public virtual IEnumerable<Identityuser> identityusers { get; set; }
		public virtual IEnumerable<Fuelpurchase> fuelpurchase { get; set; }
		public virtual IEnumerable<Logbook> logbook { get; set; }
	}
}