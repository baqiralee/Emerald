using System;

namespace Emerald.Library.Models
{
    /// <summary>
    /// This class will store the details about the all the Bookings of Emerald
    /// </summary>

    [Serializable]
    public class Booking : BaseEmerald
    {
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Total no of nights the user will stay
        /// </summary>
        public int Duration { get; set; }

        // Reference properties
        public int AccommodationId { get; set; }
        public Accommodation Accommodation { get; set; }
    }
}
