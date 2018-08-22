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

		public GeoLocationData GetCoordinates(string name)
		{
			GeoLocationData result = null;
			IGeoLocationRepository geoLocationRepository = _geoLocationRepository ?? new GeoLocationRepository();

			var geolocation = geoLocationRepository.GetCoordinates(name);


			if (geolocation != null)
			{
				result = new GeoLocationData
				{
					Name = geolocation.Name,
					Latitude = geolocation.Latitude,
					Longitude = geolocation.Longitude
				};
			}

			return result;
		}
	}
}
