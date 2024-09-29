using System;

namespace Emerald.Library.Models
{
    /// <summary>
    /// Represents the base class for all Emerald entities.
    /// This class contains common attributes that are shared across 
    /// various entities, facilitating tracking and management of records.
    /// </summary>
    [Serializable]
    public class BaseEmerald
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// This serves as the primary key in the database.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the date when the entity was created.
        /// This timestamp is recorded at the time of the entity's instantiation.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who created the entity.
        /// This can be used for auditing purposes to track who added the record.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date when the entity was last modified.
        /// This timestamp is updated whenever the entity undergoes changes.
        /// </summary>
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the user who last modified the entity.
        /// This helps in auditing and tracking changes made to the record.
        /// </summary>
        public int LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been marked as deleted.
        /// This property supports soft deletion, allowing entities to be logically removed 
        /// without physical deletion from the database.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity is active.
        /// This property can be used to enable or disable the entity in application logic.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a globally unique identifier (GUID) for the entity.
        /// This property can be used to ensure uniqueness across different systems or databases.
        /// </summary>
        public Guid Uid { get; set; }
    }
}
