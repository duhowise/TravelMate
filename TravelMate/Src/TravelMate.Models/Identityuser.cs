using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelMate.Web.Models
{
	/// <summary>
	/// A class which represents the identityusers table.
	/// </summary>
	[Table("identityusers")]
	public partial class Identityuser
	{
		[Key]
		public virtual int Id { get; set; }
		public virtual int? StaffId { get; set; }
		public virtual string UserName { get; set; }
		public virtual string Email { get; set; }
		public virtual bool EmailConfirmed { get; set; }
		public virtual string PasswordHash { get; set; }
		public virtual string SecurityStamp { get; set; }
		public virtual string PhoneNumber { get; set; }
		public virtual bool PhoneNumberConfirmed { get; set; }
		public virtual bool TwoFactorEnabled { get; set; }
		public virtual DateTime? LockoutEndDateUtc { get; set; }
		public virtual bool LockoutEnabled { get; set; }
		public virtual int AccessFailedCount { get; set; }
		public virtual Staff staff { get; set; }
		public virtual IEnumerable<Identityuserclaim> identityuserclaims { get; set; }
		public virtual IEnumerable<Identityuserrole> identityuserroles { get; set; }
		public virtual IEnumerable<Identityuserlogin> identityuserlogins { get; set; }
	}
}