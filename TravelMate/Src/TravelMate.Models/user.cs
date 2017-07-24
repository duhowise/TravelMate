using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the users table.
	/// </summary>
	[Table("users")]
	public  class User
	{
		public  int id { get; set; }
		public  int StaffId { get; set; }
		public  string UserName { get; set; }
		public  byte AccessLevelid { get; set; }
		public  string password { get; set; }
		public  DateTime DateCreated { get; set; }
		public  DateTime? Expiry { get; set; }
		public  string CreatedBy { get; set; }
		public  Staff Staff { get; set; }
		public  AccessLevel AccessLevel { get; set; }
	}
}