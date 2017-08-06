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

		private DbManager _db;

		public TravelMateBaseRepository(DbManager dbManager)
		{
			_db = dbManager;
		}
		public IEnumerable<T> GetAll<T>()
		{
			using (var connection = _db.Connection)
			{
				return _db.Connection.GetList<T>();
			}
		}

		public async Task<IEnumerable<T>> GetAllAsync<T>()
		{
			using (_db.Connection)
			{
				return await _db.Connection.GetListAsync<T>();
			}
		}

		public T Insert<T>(T member)
		{
			int? id = 0;
			using ( _db.Connection)
			{
				id= _db.Connection.Insert(member);
			}
			return GetById<T>(Convert.ToInt32(id));
		}

		public async Task<T> InsertAsync<T>(T member)
		{
			int? id = 0;
			using ( _db.Connection)
			{
				id =await _db.Connection.InsertAsync(member);
			}
			return await GetByIdAsync<T>(Convert.ToInt32(id));
		}

		public T GetById<T>(int item)
		{
			using ( _db.Connection)
			{
				return _db.Connection.Get<T>(item);
			}
		}

		public async Task<T> GetByIdAsync<T>(int item)
		{
			using ( _db.Connection)
			{
				return await _db.Connection.GetAsync<T>(item);
			}
		}

		public void Update<T>(T item)
		{
			using ( _db.Connection)
			{
				_db.Connection.Update(item);
			}
		}

		public async Task UpdateAsync<T>(T item)
		{
			using ( _db.Connection)
			{
				await _db.Connection.UpdateAsync(item);
			}
		}

		public void Delete<T>(T item)
		{
			using (_db.Connection)
			{
				_db.Connection.Delete(item);
			}
		}

		public async Task DeleteAsync<T>(T item)
		{
			using ( _db.Connection)
			{
				await _db.Connection.DeleteAsync(item);
			}
		}
	}
}