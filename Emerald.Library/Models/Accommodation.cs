using System;

namespace Emerald.Library.Models
{
    /// <summary>
    /// This class will contains the details about the accommodation that Emerald is providing
    /// </summary>

    [Serializable]
    public class Accommodation : BaseEmerald
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Reference properties
        public int AccommodationPackageId { get; set; }
        public AccommodationPackage AccommodationPackage { get; set; }
    }
}
