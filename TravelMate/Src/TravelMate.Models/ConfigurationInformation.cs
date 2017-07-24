using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the ConfigurationInformation table.
	/// </summary>
	[Table("ConfigurationInformation")]
	public  class ConfigurationInformation
	{
		[Key]
		public  int Id { get; set; }
		public  string CompanyName { get; set; }
		public  string Address { get; set; }
		public  string City { get; set; }
		public  string StateOrProvince { get; set; }
		public  string PostalCode { get; set; }
		public  string Country { get; set; }
		public  string PhoneNumber { get; set; }
		public  string FaxNumber { get; set; }
		public  string EmailAddress { get; set; }
	}
}