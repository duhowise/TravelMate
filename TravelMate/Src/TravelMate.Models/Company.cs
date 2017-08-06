using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the company table.
	/// </summary>
	[Table("company")]
	public partial class Company
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string Name { get; set; }
		public virtual int? Contactperson { get; set; }
		public virtual string Mobile { get; set; }
		public virtual string Address { get; set; }
		public virtual int Companytypeid { get; set; }
		public virtual Companytype Companytype { get; set; }
		public virtual IEnumerable<Fuelpurchase> Fuelpurchases { get; set; }
		public virtual IEnumerable<Insurance> Insurance { get; set; }
	}
}