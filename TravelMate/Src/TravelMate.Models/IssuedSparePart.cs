using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the issuedspareparts table.
	/// </summary>
	[Table("issuedspareparts")]
	public partial class Issuedsparepart
	{
		[Key]
		public virtual int id { get; set; }
		public virtual int sparepartid { get; set; }
		public virtual int? repairid { get; set; }
		public virtual int quantityused { get; set; }
		public virtual DateTime dateissued { get; set; }
		public virtual Sparepart sparepart { get; set; }
		public virtual Repair repair { get; set; }
	}
}