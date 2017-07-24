using System.Collections.Generic;

namespace TravelMate.Data
{
	public   interface  IRepository
	{
		IEnumerable<T> GetAll<T>();
		T Insert<T>(T member);
		T GetById<T>(int item);
		void Update<T>(T item);
		void Delete<T>(T item);
	}
}