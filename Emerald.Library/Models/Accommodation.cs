using System;
using System.Collections.Generic;

namespace Emerald.Library.Models
{
    /// <summary>
    /// Represents an accommodation offered by Emerald.
    /// This class contains essential details about the accommodation, 
    /// including its name, description, and associated packages.
    /// </summary>
    [Serializable]
    public class Accommodation : BaseEmerald
    {
        /// <summary>
        /// Gets or sets the name of the accommodation.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the accommodation.
        /// Provides additional details and highlights about the accommodation.
        /// </summary>
        public string Description { get; set; }

        // Reference properties

        /// <summary>
        /// Gets or sets the identifier for the associated accommodation package.
        /// Each accommodation must be linked to at least one accommodation package.
        /// </summary>
        public int AccommodationPackageId { get; set; }

        /// <summary>
        /// Navigation property for the associated accommodation package.
        /// </summary>
        public virtual AccommodationPackage AccommodationPackage { get; set; }

        /// <summary>
        /// Navigation property for the bookings associated with this accommodation.
        /// One accommodation can be linked to multiple bookings.
        /// </summary>
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}