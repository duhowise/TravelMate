using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the roadworthy table.
	/// </summary>
	[Table("roadworthy")]
	public partial class Roadworthy
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int? vehicleid { get; set; }
		public virtual DateTime? issuedate { get; set; }
		public virtual DateTime? renewaldate { get; set; }
		public virtual int? driverid { get; set; }
		public virtual Vehicle vehicle { get; set; }
	}
}