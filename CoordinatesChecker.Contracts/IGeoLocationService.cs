using CoordinatesChecker.Data.Entities;
using System.ServiceModel;

namespace CoordinatesChecker.Contracts
{
	[ServiceContract]
	public interface IGeoLocationService
	{
		[OperationContract]
		GeoLocation GetCoordinates(string name);
	}
}
