using System;

namespace Emerald.Library.Models
{
    /// <summary>
    /// Represents a booking made by a user at Emerald.
    /// This class stores details about the booking, including the 
    /// dates, duration of stay, and associated accommodation.
    /// </summary>
    [Serializable]
    public class Booking : BaseEmerald
    {
        /// <summary>
        /// Gets or sets the start date of the booking.
        /// Indicates when the user intends to begin their stay.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the total number of nights the user will stay.
        /// This value is calculated based on the booking duration.
        /// </summary>
        public int Duration { get; set; }

        // Reference properties

        /// <summary>
        /// Gets or sets the identifier for the associated accommodation.
        /// Each booking must be linked to at least one accommodation.
        /// </summary>
        public int AccommodationId { get; set; }

        /// <summary>
        /// Navigation property for the associated accommodation.
        /// </summary>
        public virtual Accommodation Accommodation { get; set; }
    }
}
