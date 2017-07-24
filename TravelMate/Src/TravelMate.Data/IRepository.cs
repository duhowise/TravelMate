using System.Collections.Generic;
using System.Threading.Tasks;

namespace TravelMate.Data
{
	public   interface  IRepository
	{
		IEnumerable<T> GetAll<T>();
		Task<IEnumerable<T>> GetAllAsync<T>();
		T Insert<T>(T member);
		Task<T> InsertAsync<T>(T member);
		T GetById<T>(int item);
		Task<T> GetByIdAsync<T>(int item);
		void Update<T>(T item);
		Task UpdateAsync<T>(T item);
		void Delete<T>(T item);
		Task DeleteAsync<T>(T item);
	}
}