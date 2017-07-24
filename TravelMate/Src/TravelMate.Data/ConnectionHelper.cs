using System.Configuration;

namespace TravelMate.Data
{
	public static class ConnectionHelper
	{
		private static string _connectionstrig;

		public static string Connectionstrig()
		{
			if (string.IsNullOrWhiteSpace(_connectionstrig))
			{
				_connectionstrig = ConfigurationManager.ConnectionStrings["TravelConnection"].ConnectionString;
			}
			return _connectionstrig;
		}
		
	}
}