using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the configurationinformation table.
	/// </summary>
	[Table("configurationinformation")]
	public partial class Configurationinformation
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string companyname { get; set; }
		public virtual string address { get; set; }
		public virtual string city { get; set; }
		public virtual string stateorprovince { get; set; }
		public virtual string postalcode { get; set; }
		public virtual string country { get; set; }
		public virtual string phonenumber { get; set; }
		public virtual string faxnumber { get; set; }
		public virtual string emailaddress { get; set; }
	}
}