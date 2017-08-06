using System.Collections.Generic;
using System.Linq;
using Dapper;

namespace TravelMate.Data
{
	public class UserTable<TUser>
		where TUser : IdentityMember
	{
		private DbManager db;

		/// <summary>
		/// Constructor that takes a DbManager instance 
		/// </summary>
		/// <param name="database"></param>
		public UserTable(DbManager database)
		{
			db = database;
		}

		/// <summary>
		/// Returns the Member's name given a Member id
		/// </summary>
		/// <param name="memberId"></param>
		/// <returns></returns>
		public string GetUserName(int memberId)
		{
			return db.Connection.ExecuteScalar<string>("Select UserName from IdentityUsers where Id=@MemberId", new { MemberId = memberId });
		}

		/// <summary>
		/// Returns a Member ID given a Member name
		/// </summary>
		/// <param name="userName">The Member's name</param>
		/// <returns></returns>
		public int GetmemberId(string userName)
		{
			return db.Connection.ExecuteScalar<int>("Select Id from IdentityUsers where UserName=@UserName", new { UserName = userName });
		}

		/// <summary>
		/// Returns an TUser given the Member's id
		/// </summary>
		/// <param name="memberId">The Member's id</param>
		/// <returns></returns>
		public TUser GetUserById(int memberId)
		{
			return db.Connection.Query<TUser>("Select * from IdentityUsers where Id=@MemberId", new { MemberId = memberId })
				.FirstOrDefault();
		}

		/// <summary>
		/// Returns a list of TUser instances given a Member name
		/// </summary>
		/// <param name="userName">Member's name</param>
		/// <returns></returns>
		public List<TUser> GetUserByName(string userName)
		{
			return db.Connection.Query<TUser>("Select * from IdentityUsers where UserName=@UserName", new { UserName = userName })
				.ToList();
		}

		public List<TUser> GetUserByEmail(string email)
		{
			return null;
		}

		/// <summary>
		/// Return the Member's password hash
		/// </summary>
		/// <param name="memberId">The Member's id</param>
		/// <returns></returns>
		public string GetPasswordHash(int memberId)
		{
			return db.Connection.ExecuteScalar<string>("Select PasswordHash from IdentityUsers where Id = @MemberId", new { MemberId = memberId });
		}

		/// <summary>
		/// Sets the Member's password hash
		/// </summary>
		/// <param name="memberId"></param>
		/// <param name="passwordHash"></param>
		/// <returns></returns>
		public void SetPasswordHash(int memberId, string passwordHash)
		{
			db.Connection.Execute(@"
					UPDATE
						Member
					SET
						PasswordHash = @pwdHash
					WHERE
						Id = @Id", new { pwdHash = passwordHash, Id = memberId });
		}

		/// <summary>
		/// Returns the Member's security stamp
		/// </summary>
		/// <param name="memberId"></param>
		/// <returns></returns>
		public string GetSecurityStamp(int memberId)
		{
			return db.Connection.ExecuteScalar<string>("Select SecurityStamp from Member where Id = @MemberId", new { MemberId = memberId });
		}

		/// <summary>
		/// Inserts a new Member in the Users table
		/// </summary>
		/// <param name="Member"></param>
		/// <returns></returns>
		public void Insert(TUser member)
		{
			var id = db.Connection.ExecuteScalar<int>(@"INSERT INTO identityusers(UserName ,Email ,EmailConfirmed ,PasswordHash ,SecurityStamp
					,PhoneNumber ,PhoneNumberConfirmed ,TwoFactorEnabled ,LockoutEndDateUtc ,LockoutEnabled
						,AccessFailedCount)VALUES(@UserName,@Email,@EmailConfirmed,@PasswordHash,@SecurityStamp
						,@PhoneNumber,@PhoneNumberConfirmed,@TwoFactorEnabled,@LockoutEndDateUtc,@LockoutEnabled,@AccessFailedCount );
						SELECT LAST_INSERT_ID()", member);
			// we need to set the id to the returned identity generated from the db
			member.Id = id;
		}

		/// <summary>
		/// Deletes a Member from the Users table
		/// </summary>
		/// <param name="memberId">The Member's id</param>
		/// <returns></returns>
		private void Delete(int memberId)
		{
			db.Connection.Execute(@"Delete from IdentityUsers where Id = @MemberId", new { MemberId = memberId });
		}

		/// <summary>
		/// Deletes a Member from the Users table
		/// </summary>
		/// <param name="Member"></param>
		/// <returns></returns>
		public void Delete(TUser Member)
		{
			Delete(Member.Id);
		}

		/// <summary>
		/// Updates a Member in the Users table
		/// </summary>
		/// <param name="Member"></param>
		/// <returns></returns>
		public void Update(TUser member)
		{
			db.Connection
				.Execute(@"
							Update IdentityUsers set UserName = @userName, PasswordHash = @pswHash, SecurityStamp = @secStamp, 
				Email=@email, EmailConfirmed=@emailconfirmed, PhoneNumber=@phonenumber, PhoneNumberConfirmed=@phonenumberconfirmed,
				AccessFailedCount=@accesscount, LockoutEnabled=@lockoutenabled, LockoutEndDateUtc=@lockoutenddate, TwoFactorEnabled=@twofactorenabled  
				WHERE Id = @memberId",
					new
					{
						userName = member.UserName,
						pswHash = member.PasswordHash,
						secStamp = member.SecurityStamp,
						memberId = member.Id,
						email = member.Email,
						emailconfirmed = member.EmailConfirmed,
						phonenumber = member.PhoneNumber,
						phonenumberconfirmed = member.PhoneNumberConfirmed,
						accesscount = member.AccessFailedCount,
						lockoutenabled = member.LockoutEnabled,
						lockoutenddate = member.LockoutEndDateUtc,
						twofactorenabled = member.TwoFactorEnabled
					}
				);
		}
	}
}