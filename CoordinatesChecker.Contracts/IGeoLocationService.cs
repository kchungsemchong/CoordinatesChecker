using CoordinatesChecker.Data.Entities;
using System.ServiceModel;

namespace CoordinatesChecker.Contracts
{
	[ServiceContract]
	public interface IGeoLocationService
	{
		[OperationContract]
		GeoLocationData GetCoordinates(string name);
	}
}
