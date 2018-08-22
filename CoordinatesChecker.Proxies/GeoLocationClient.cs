using CoordinatesChecker.Contracts;
using System.ServiceModel;

namespace CoordinatesChecker.Proxies
{
	public class GeoLocationClient : ClientBase<IGeoLocationService>, IGeoLocationService
	{
		public GeoLocationClient(string endpoint) : base (endpoint) 
		{
			//This will allow us to specify the desired enpoint which is found in the config
		}

		public GeoLocationData GetCoordinates(string name)
		{
			return Channel.GetCoordinates(name);
		}
	}
}
