using CoordinatesChecker.Contracts;
using CoordinatesChecker.Data.Entities;
using System.ServiceModel;

namespace CoordinatesChecker.Proxies
{
	public class GeoLocationClient : ClientBase<IGeoLocationService>, IGeoLocationService
	{
		public GeoLocation GetCoordinates(string name)
		{
			return Channel.GetCoordinates(name);
		}
	}
}
