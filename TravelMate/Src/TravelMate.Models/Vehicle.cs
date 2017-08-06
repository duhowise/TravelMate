using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the vehicle table.
	/// </summary>
	[Table("vehicle")]
	public partial class Vehicle
	{
		[Key]
		public virtual int id { get; set; }
		public virtual string make { get; set; }
		public virtual string model { get; set; }
		public virtual int? year { get; set; }
		public virtual string color { get; set; }
		public virtual string vehiclenumber { get; set; }
		public virtual string vinnumber { get; set; }
		public virtual int typeid { get; set; }
		public virtual DateTime purchasedate { get; set; }
		public virtual double purchaseprice { get; set; }
		public virtual double? purchasemileage { get; set; }
		public virtual byte[] attachments { get; set; }
		public virtual string description { get; set; }
		public virtual string grossweight { get; set; }
		public virtual string enginesize { get; set; }
		public virtual string enginecapacity { get; set; }
		public virtual int fronttyretype { get; set; }
		public virtual int? reartyretype { get; set; }
		public virtual string state { get; set; }
		public virtual int? transmissiontype { get; set; }
		public virtual int? batterytypeid { get; set; }
		public virtual int? filtertype { get; set; }
		public virtual int? batterycount { get; set; }
		public virtual int? filtercount { get; set; }
		public virtual int? fronttyrecount { get; set; }
		public virtual int? reartyrecount { get; set; }
		public virtual Vehicletype vehicletype { get; set; }
		public virtual Tyretype tyretype { get; set; }
		public virtual Vehicletranmission vehicletranmission { get; set; }
		public virtual Batterytype batterytype { get; set; }
		public virtual IEnumerable<Insurance> insurance { get; set; }
		public virtual IEnumerable<Roadworthy> roadworthy { get; set; }
		public virtual IEnumerable<Repair> repairs { get; set; }
		public virtual IEnumerable<Gatepass> gatepass { get; set; }
		public virtual IEnumerable<Expense> expense { get; set; }
		public virtual IEnumerable<Fuelpurchase> fuelpurchase { get; set; }
		public virtual IEnumerable<Logbook> logbook { get; set; }
	}
}