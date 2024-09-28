using System;
using Emerald.Library.Enums;

namespace Emerald.Library.Models
{
    /// <summary>
    /// This class will contains the details about the accommodation packages that Emerald is providing
    /// </summary>

    [Serializable]
    public class AccommodationPackage : BaseEmerald
    {
        public string Name { get; set; }
        public AccommodationType AccommodationTypeID { get; set; }
        public int NumberOfRooms { get; set; }
        public decimal Charges { get; set; }
    }
}
