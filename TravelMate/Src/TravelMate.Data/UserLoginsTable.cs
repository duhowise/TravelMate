using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.AspNet.Identity;

namespace TravelMate.Data
{
	/// <summary>
	/// Class that represents the UserLogins table in the Database
	/// </summary>
	public class UserLoginsTable
	{
		private DbManager db;

		/// <summary>
		/// Constructor that takes a DbManager instance 
		/// </summary>
		/// <param name="database"></param>
		public UserLoginsTable(DbManager database)
		{
			db = database;
		}

		/// <summary>
		/// Deletes a login from a user in the UserLogins table
		/// </summary>
		/// <param name="user">User to have login deleted</param>
		/// <param name="login">Login to be deleted from user</param>
		/// <returns></returns>
		public void Delete(IdentityMember member, UserLoginInfo login)
		{
			db.Connection.Execute(@"Delete from IdentityUserLogins 
					where UserID = @userId 
					and LoginProvider = @loginProvider 
					and ProviderKey = @providerKey",
				new
				{
					userId = member.Id,
					loginProvider = login.LoginProvider,
					providerKey = login.ProviderKey
				});
		}

		/// <summary>
		/// Deletes all Logins from a user in the UserLogins table
		/// </summary>
		/// <param name="userId">The user's id</param>
		/// <returns></returns>
		public void Delete(int userId)
		{
			db.Connection.Execute(@"Delete from IdentityUserLogins 
					where UserID = @userId", new { userId = userId });
		}

		/// <summary>
		/// Inserts a new login in the UserLogins table
		/// </summary>
		/// <param name="user">User to have new login added</param>
		/// <param name="login">Login to be added</param>
		/// <returns></returns>
		public void Insert(IdentityMember member, UserLoginInfo login)
		{
			db.Connection.Execute(@"Insert into IdentityUserLogins 
				(LoginProvider, ProviderKey, UserID) 
				values (@loginProvider, @providerKey, @userId)",
				new
				{
					loginProvider = login.LoginProvider,
					providerKey = login.ProviderKey,
					userId = member.Id
				});
		}

		/// <summary>
		/// Return a userId given a user's login
		/// </summary>
		/// <param name="MemberLogin">The user's login info</param>
		/// <returns></returns>
		public int FindUserIdByLogin(UserLoginInfo MemberLogin)
		{
			return db.Connection.ExecuteScalar<int>(@"Select UserID from IdentityUserLogins 
				where LoginProvider = @loginProvider and ProviderKey = @providerKey",
				new
				{
					loginProvider = MemberLogin.LoginProvider,
					providerKey = MemberLogin.ProviderKey
				});
		}

		/// <summary>
		/// Returns a list of user's logins
		/// </summary>
		/// <param name="userId">The user's id</param>
		/// <returns></returns>
		public List<UserLoginInfo> FindByUserId(int memberId)
		{
			return db.Connection.Query<UserLoginInfoEx>("Select * from IdentityUserLogins where UserID = @memberId", new { memberId = memberId })
				.Select(user => new UserLoginInfo(user.LoginProvider, user.ProviderKey))
				.ToList();
		}
	}
	public class UserLoginInfoEx
	{
		/// <summary>
		///     Provider for the linked login, i.e. Facebook, Google, etc.
		/// </summary>
		public string LoginProvider { get; set; }

		/// <summary>
		///     User specific key for the login provider
		/// </summary>
		public string ProviderKey { get; set; }
	}
}
