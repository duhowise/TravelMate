using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the spareparts table.
	/// </summary>
	[Table("spareparts")]
	public partial class Sparepart
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string name { get; set; }
		public virtual string description { get; set; }
		public virtual int quantity { get; set; }
		public virtual IEnumerable<Issuedsparepart> issuedspareparts { get; set; }
	}
}