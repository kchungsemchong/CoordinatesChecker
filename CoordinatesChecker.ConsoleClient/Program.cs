using CoordinatesChecker.Contracts;
using CoordinatesChecker.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesChecker.ConsoleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Enter your Location");
			//string location = Console.ReadLine();
			string location = "Port Louis";
			if (!string.IsNullOrEmpty(location))
			{
				GeoLocationClient proxy = new GeoLocationClient("tcpEP");

				GeoLocationData data = proxy.GetCoordinates(location);
				if(data != null)
				{
					Console.WriteLine(data.Name);
					Console.WriteLine(string.Concat("Latitude: ", data.Latitude));
					Console.WriteLine(string.Concat("Longitude: ", data.Longitude));
				}
			}
			else
			{
				Console.WriteLine("No location entered");
			}
			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
