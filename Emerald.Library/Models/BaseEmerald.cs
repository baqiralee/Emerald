using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Emerald.Library.Models
{
    /// <summary>
    /// This is the base class of Emerald having base attributes
    /// </summary>
    
    [Serializable]
    public class BaseEmerald
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Guid Uid { get; set; }
    }
}
