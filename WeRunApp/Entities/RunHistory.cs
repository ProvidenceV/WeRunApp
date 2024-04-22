using System.ComponentModel.DataAnnotations.Schema;
using WeRunApp.Utilities;

namespace WeRunApp.Entities
{
    [Table("RunHistory")]
    public class RunHistory
    {
        public int? HistoryId { get; set; }
        public int? UserId { get; set; }
        public int? TotalRuns { get; set; }
        public double? TotalDistance { get; set; } //distance in meters, can convert with constants
        public int? TotalCalories { get; set; }
        public TimeSpan? BestTime { get; set; }
        public double? BestDistance { get; set; }

        //functions
        public double GetDistanceInKilometers(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToKilometers(DistanceInMeters);
        }

        public double GetDistanceInMiles(double DistanceInMeters)
        {
            return DistanceConverter.ConvertMetersToMiles(DistanceInMeters);
        }

        //relationship
        public User User { get; set; }
    }
}
