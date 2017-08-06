using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the logbook table.
	/// </summary>
	[Table("logbook")]
	public partial class Logbook
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int Vehicleid { get; set; }
		public virtual int Driverid { get; set; }
		public virtual string Purpose { get; set; }
		public virtual string Startlocation { get; set; }
		public virtual string Destination { get; set; }
		public virtual DateTime Timestarted { get; set; }
		public virtual DateTime Timearrived { get; set; }
		public virtual int? Startspeed { get; set; }
		public virtual int? Finishspeed { get; set; }
		public virtual int Fuelused { get; set; }
		public virtual Vehicle Vehicle { get; set; }
		public virtual Staff Staff { get; set; }
	}
}