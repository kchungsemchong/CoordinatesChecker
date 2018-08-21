using CoordinatesChecker.Data.Entities;

namespace CoordinatesChecker.Data.Repositories
{
	public interface IGeoLocationRepository
	{
		GeoLocation GetCoordinates(string name);
	}
}
