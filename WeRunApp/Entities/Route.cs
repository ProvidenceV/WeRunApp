using System.ComponentModel.DataAnnotations.Schema;
using WeRunApp.Utilities;

namespace WeRunApp.Entities
{
    [Table("Routes")]
    public class Route
    {
        public int RouteId { get; set; }
        public string? RouteName { get; set; }
        public string? StartPoint { get; set; }
        public string? EndPoint { get; set; }
        public double? TotalDistance { get; set; } //distance in meters, can convert with constants
        public string? MapData { get; set; }
        public double? ElevationGain { get; set; }

        public double GetDistanceInKilometers(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToKilometers(DistanceInMeters);
        }

        public double GetDistanceInMiles(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToMiles(DistanceInMeters);
        }
    }
}
