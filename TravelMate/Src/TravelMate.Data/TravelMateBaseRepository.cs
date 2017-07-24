using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
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
						connection.Open();
				return  connection.GetList<T>();
			}
		}

		public async Task<IEnumerable<T>> GetAllAsync<T>()
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						await	connection.OpenAsync();
				return await connection.GetListAsync<T>();
			}
		}

		public T Insert<T>(T member)
		{
			int? id = 0;
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						connection.Open();
				id= connection.Insert(member);
			}
			return GetById<T>(Convert.ToInt32(id));
		}

		public async Task<T> InsertAsync<T>(T member)
		{
			int? id = 0;
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						await connection.OpenAsync();
				id =await connection.InsertAsync(member);
			}
			return await GetByIdAsync<T>(Convert.ToInt32(id));
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

		public async Task<T> GetByIdAsync<T>(int item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						await	connection.OpenAsync();
				return await connection.GetAsync<T>(item);
			}
		}

		public void Update<T>(T item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						connection.Open();
				connection.Update(item);
			}
		}

		public async Task UpdateAsync<T>(T item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						await	connection.OpenAsync();
			 await	connection.UpdateAsync(item);
			}
		}

		public void Delete<T>(T item)
		{
			using (var connection = new MySqlConnection( ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						connection.Open();
				connection.Delete(item);
			}
		}

		public async Task DeleteAsync<T>(T item)
		{
			using (var connection = new MySqlConnection(ConnectionHelper.Connectionstrig()))
			{
				if (connection.State != ConnectionState.Open)
						await	connection.OpenAsync();
			await	connection.DeleteAsync(item);
			}
		}
	}
}