using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the license table.
	/// </summary>
	[Table("license")]
	public partial class License
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int staffid { get; set; }
		public virtual int licencetypeid { get; set; }
		public virtual string licenseno { get; set; }
		public virtual bool? temporary { get; set; }
		public virtual DateTime issued { get; set; }
		public virtual DateTime expiry { get; set; }
		public virtual Staff staff { get; set; }
		public virtual Licensetype licensetype { get; set; }
	}
}