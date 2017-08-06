using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the insurance table.
	/// </summary>
	[Table("insurance")]
	public partial class Insurance
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int? vehicleid { get; set; }
		public virtual string policyno { get; set; }
		public virtual int? issuerid { get; set; }
		public virtual int? typeid { get; set; }
		public virtual double? cost { get; set; }
		public virtual DateTime? issuedate { get; set; }
		public virtual DateTime? expirydate { get; set; }
		public virtual string remarks { get; set; }
		public virtual Vehicle vehicle { get; set; }
		public virtual Company company { get; set; }
		public virtual Insurancetype insurancetype { get; set; }
	}
}