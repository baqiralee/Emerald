using System;
using System.Collections.Generic;
using Emerald.Library.Enums;

namespace Emerald.Library.Models
{
    /// <summary>
    /// Represents an accommodation package provided by Emerald.
    /// This class contains key details about the package, such as its type, 
    /// number of rooms, and associated charges.
    /// </summary>
    [Serializable]
    public class AccommodationPackage : BaseEmerald
    {
        /// <summary>
        /// Gets or sets the name of the accommodation package.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the accommodation type identifier.
        /// This property indicates the type of accommodation (e.g., hotel, cabin, etc.).
        /// </summary>
        public AccommodationType AccommodationTypeID { get; set; }

        /// <summary>
        /// Gets or sets the total number of rooms included in this package.
        /// </summary>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Gets or sets the charges associated with the accommodation package.
        /// This represents the cost for booking the package.
        /// </summary>
        public decimal Charges { get; set; }

        // Reference properties

        /// <summary>
        /// Navigation property for the accommodations associated with this package.
        /// One accommodation package can be linked to multiple accommodations.
        /// </summary>
        public virtual ICollection<Accommodation> Accommodations { get; set; } = new List<Accommodation>();
    }
}
