using Emerald.DbConfiguration.Configurations;
using Emerald.Library.Models;
using System.Data.Entity.ModelConfiguration;

namespace Emerald.DbConfiguration.Configurations
{
    /// <summary>
    /// Configures the properties and relationships for the AccommodationPackage entity class.
    /// This configuration class defines how the AccommodationPackage entity maps to the database.
    /// </summary>
    public class AccommodationPackageConfig : EntityTypeConfiguration<AccommodationPackage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccommodationPackageConfig"/> class.
        /// This constructor sets up the table name, properties, and relationships for the AccommodationPackage entity.
        /// </summary>
        public AccommodationPackageConfig()
        {
            // Table name configuration
            ToTable("AccommodationPackages", "emerald");

            // Apply base configuration
            new BaseEmeraldConfig().BasePropConfig(this);

            // Name property configuration
            Property(prop => prop.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .HasColumnOrder(6)
                .IsRequired();

            // AccommodationTypeID property configuration
            Property(prop => prop.AccommodationTypeID)
                .HasColumnName("AccommodationTypeID")
                .HasColumnType("int")
                .HasColumnOrder(7)
                .IsRequired();

            // NumberOfRooms property configuration
            Property(prop => prop.NumberOfRooms)
                .HasColumnName("RoomQuantity")
                .HasColumnType("int")
                .HasColumnOrder(8)
                .IsRequired();

            // Charges property configuration
            Property(prop => prop.Charges)
                .HasColumnName("Charges")
                .HasColumnType("decimal")
                .HasColumnOrder(9)
                .HasPrecision(18, 2)
                .IsRequired();

            // IsDeleted property display order configuration
            Property(prop => prop.IsDeleted)
                .HasColumnOrder(10);

            // IsActive property display order configuration
            Property(prop => prop.IsActive)
                .HasColumnOrder(11);

            // One-to-many relationship configuration
            HasMany(a => a.Accommodations)                          // Configures the one-to-many relationship
                .WithRequired(a => a.AccommodationPackage)          // Specifies the required relationship to AccommodationPackage
                .HasForeignKey(a => a.AccommodationPackageId)       // Sets the foreign key property
                .WillCascadeOnDelete(false);                        // Prevents cascade delete
        }
    }
}
