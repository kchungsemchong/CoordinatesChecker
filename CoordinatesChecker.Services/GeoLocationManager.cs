using CoordinatesChecker.Contracts;
using CoordinatesChecker.Data.Entities;
using CoordinatesChecker.Data.Repositories;

namespace CoordinatesChecker.Services
{
	public class GeoLocationManager : IGeoLocationService
    {
		IGeoLocationRepository _geoLocationRepository = null; 

		public GeoLocationManager()
		{
		}

		public GeoLocationManager(IGeoLocationRepository geoLocationRepository)
		{
			_geoLocationRepository = geoLocationRepository;
		}

		public GeoLocation GetCoordinates(string name)
		{
			GeoLocation result = null;
			result = _geoLocationRepository.GetCoordinates(name);

			return result;
		}
	}
}
