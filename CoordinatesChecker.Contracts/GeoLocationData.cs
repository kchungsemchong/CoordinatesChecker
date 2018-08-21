using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CoordinatesChecker.Contracts
{
	[DataContract]
    public class GeoLocationData
    {
		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public double Latitude { get; set; }

		[DataMember]
		public double Longitude { get; set; }
	}
}
