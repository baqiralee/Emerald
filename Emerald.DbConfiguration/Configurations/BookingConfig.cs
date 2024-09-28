using Emerald.Library.Models;
using System.Data.Entity.ModelConfiguration;

namespace Emerald.DbConfiguration.Configurations
{
    /// <summary>
    /// Configures the properties for the Booking entity class.
    /// This configuration class defines how the Booking entity maps to the database.
    /// </summary>
    public class BookingConfig : EntityTypeConfiguration<Booking>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookingConfig"/> class.
        /// This constructor sets up the table name and properties for the Booking entity.
        /// </summary>
        public BookingConfig()
        {
            // Table name configuration
            ToTable("Bookings", "emerald");

            // Apply base configuration
            new BaseEmeraldConfig().BasePropConfig(this);

            // StartDate property configuration
            Property(prop => prop.StartDate)
                .HasColumnName("StartDate")
                .HasColumnType("datetime")
                .HasColumnOrder(6)
                .IsRequired();

            // Duration property configuration
            Property(prop => prop.Duration)
                .HasColumnName("Duration")
                .HasColumnName("int")
                .HasColumnOrder(7)
                .IsRequired();

            // IsDeleted property display order configuration
            Property(prop => prop.IsDeleted)
                .HasColumnOrder(8);

            // IsActive property display order configuration
            Property(prop => prop.IsActive)
                .HasColumnOrder(9);
        }
    }
}