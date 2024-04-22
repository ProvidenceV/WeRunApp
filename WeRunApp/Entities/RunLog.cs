using System.ComponentModel.DataAnnotations.Schema;
using WeRunApp.Utilities;

namespace WeRunApp.Entities
{
    [Table("RunLogs")]
    public class RunLog
    {
        public int RunId { get; set; }
        public int UserId { get; set; }
        public int? RouteId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public TimeSpan? Duration { get; set; }
        public double? Distance { get; set; } //distance in meters, can convert with constants
        public int? CaloriesBurned { get; set; }

        //functions
        public double GetDistanceInKilometers(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToKilometers(DistanceInMeters);
        }

        public double GetDistanceInMiles(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToMiles(DistanceInMeters);
        }

        // relationship
        public User User { get; set; }
        public Route Route { get; set; }
    }
}
