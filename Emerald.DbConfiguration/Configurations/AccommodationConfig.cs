using Emerald.DbConfiguration.Configurations;
using Emerald.Library.Models;
using System.Data.Entity.ModelConfiguration;

namespace Emerald.DbConfiguration.Configurations
{
    /// <summary>
    /// Configures the properties and relationships for the Accommodation entity class.
    /// This configuration class defines how the Accommodation entity maps to the database.
    /// </summary>
    public class AccommodationConfig : EntityTypeConfiguration<Accommodation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccommodationConfig"/> class.
        /// This constructor sets up the table name, properties, and relationships for the Accommodation entity.
        /// </summary>
        public AccommodationConfig()
        {
            // Table name configuration
            ToTable("Accommodations", "emerald");

            // Apply base configuration
            new BaseEmeraldConfig().BasePropConfig(this);

            // Name property configuration
            Property(prop => prop.Name)
                .HasColumnName("Name")
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .HasColumnOrder(6)
                .IsRequired();

            // Description property configuration
            Property(prop => prop.Description)
                .HasColumnName("Description")
                .HasMaxLength(500)
                .HasColumnType("nvarchar")
                .HasColumnOrder(7)
                .IsRequired();

            // IsDeleted property display order configuration
            Property(prop => prop.IsDeleted)
                .HasColumnOrder(8);

            // IsActive property display order configuration
            Property(prop => prop.IsActive)
                .HasColumnOrder(9);

            // One-to-many relationship configuration
            HasMany(a => a.Bookings)                       // Configures the one-to-many relationship
                .WithRequired(a => a.Accommodation)        // Specifies the required relationship to Accommodation
                .HasForeignKey(a => a.AccommodationId)     // Sets the foreign key property
                .WillCascadeOnDelete(false);               // Prevents cascade delete
        }
    }
}
