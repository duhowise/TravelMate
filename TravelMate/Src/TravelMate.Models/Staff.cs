using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Models
{
	/// <summary>
	/// A class which represents the Staff table.
	/// </summary>
	[Table("Staff")]
	public  class Staff
	{
		[Key]
		public  int Id { get; set; }
		public  string FirstName { get; set; }
		public  string LastName { get; set; }
		public  int StaffDesignationId { get; set; }
		public  DateTime EmploymentDate { get; set; }
		public  int createdBy { get; set; }
		public  StaffDesignation StaffDesignation { get; set; }
		public  IEnumerable<User> users { get; set; }
		public  IEnumerable<FuelPurchase> FuelPurchase { get; set; }
		public  IEnumerable<LogBook> LogBook { get; set; }
		public  IEnumerable<GatePass> GatePass { get; set; }
		public  IEnumerable<License> License { get; set; }
	}
}