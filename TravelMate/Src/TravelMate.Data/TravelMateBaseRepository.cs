using System.Collections.Generic;
using System.Data;
using Dapper;
using MySql.Data.MySqlClient;

namespace TravelMate.Data
{
	public class TravelMateBaseRepository:IRepository
	{
		public IEnumerable<T> GetAll<T>()
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
					connection.OpenAsync();
				return connection.GetList<T>();
			}
		}

		public T Insert<T>(T member)
		{
			int id = 0;
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
					connection.OpenAsync();
				id= (int) connection.Insert(member);
			}
			return GetById<T>(id);
		}

		public T GetById<T>(int item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
					connection.Open();
				return  connection.Get<T>(item);
			}
		}

		public void Update<T>(T item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
					connection.OpenAsync();
				connection.Update(item);
			}
		}

		public void Delete<T>(T item)
		{
			using (var connection = new MySqlConnection( ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
					connection.OpenAsync();
				connection.Delete(item);
			}
		}
	}
}