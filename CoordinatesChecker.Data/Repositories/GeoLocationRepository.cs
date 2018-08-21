using CoordinatesChecker.Data.Entities;
using System;

namespace CoordinatesChecker.Data.Repositories
{
	public class GeoLocationRepository : IGeoLocationRepository
	{
		public GeoLocation GetCoordinates(string name)
		{
			GeoLocation result = null;

			if (name == "Port Louis")
			{
				var geolocation = new GeoLocation
				{
					Name = "Port Louis",
					Latitude = -20.1608912,
					Longitude = 57.5012222
				};

				result = geolocation;
			}

			return result;
		}	
	}
}
