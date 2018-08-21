using CoordinatesChecker.Services;
using System;
using System.ServiceModel;

namespace CoordinatesChecker.ConsoleHost
{
	class Program
	{
		static void Main(string[] args)
		{
			ServiceHost hostGeoManager = new ServiceHost(typeof(GeoLocationManager));
			hostGeoManager.Open();

			Console.WriteLine("Services started. Press [Enter] to exit");
			Console.ReadLine();

			hostGeoManager.Close();
		}
	}
}
