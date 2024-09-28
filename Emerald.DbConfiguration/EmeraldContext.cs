using Emerald.DbConfiguration.Configurations;
using Emerald.Library.Models;
using System.Data.Entity;

namespace Emerald.DbConfiguration
{
    /// <summary>
    /// Represents the database context for the Emerald application.
    /// This class manages the entity objects during runtime and facilitates data access.
    /// </summary>
    public class EmeraldContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmeraldContext"/> class.
        /// This constructor sets up the connection string for the context.
        /// </summary>
        public EmeraldContext() : base("EmeraldConnectionString")
        {
        }

        /// <summary>
        /// Gets or sets the accommodation packages in the database.
        /// </summary>
        public DbSet<AccommodationPackage> AccomodationPackages { get; set; }

        /// <summary>
        /// Gets or sets the accommodations in the database.
        /// </summary>
        public DbSet<Accommodation> Accomodations { get; set; }

        /// <summary>
        /// Gets or sets the bookings in the database.
        /// </summary>
        public DbSet<Booking> Bookings { get; set; }

        /// <summary>
        /// Configures the models using the fluent API.
        /// This method is called when the context is being created.
        /// </summary>
        /// <param name="configurator">The model builder to configure the model.</param>
        protected override void OnModelCreating(DbModelBuilder configurator)
        {
            // Adding entity configurations
            configurator.Configurations.Add(new AccommodationPackageConfig());
            configurator.Configurations.Add(new AccommodationConfig());
            configurator.Configurations.Add(new BookingConfig());

            // Call the base method to ensure the model is properly configured
            base.OnModelCreating(configurator);
        }
    }
}
