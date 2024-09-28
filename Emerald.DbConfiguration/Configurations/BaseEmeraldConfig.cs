using Emerald.Library.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Emerald.DbConfiguration.Configurations
{
    /// <summary>
    /// Configures the properties for the BaseEmerald class, which will be inherited by all entity classes.
    /// This configuration class defines how the BaseEmerald entity maps to the database.
    /// </summary>
    public class BaseEmeraldConfig
    {
        /// <summary>
        /// Configures the base properties for a given entity type that inherits from BaseEmerald.
        /// </summary>
        /// <typeparam name="TEntity">The type of the entity that extends BaseEmerald.</typeparam>
        /// <param name="_this">The entity type configuration to apply the settings to.</param>
        public void BasePropConfig<TEntity>(EntityTypeConfiguration<TEntity> _this) where TEntity : BaseEmerald
        {
            // Primary key configuration
            _this.HasKey(key => key.ID);

            // ID property configuration
            _this.Property(prop => prop.ID)
                .HasColumnName("ID")
                .HasColumnOrder(0)
                .HasColumnType("bigint")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            // CreateDate property configuration
            _this.Property(prop => prop.CreateDate)
                .HasColumnName("CreateDate")
                .HasColumnOrder(1)
                .HasColumnType("datetime")
                .IsRequired();

            // CreatedBy property configuration
            _this.Property(prop => prop.CreatedBy)
                .HasColumnName("CreatedBy")
                .HasColumnOrder(2)
                .HasColumnType("bigint")
                .IsRequired();

            // LastModifiedDate property configuration
            _this.Property(prop => prop.LastModifiedDate)
                .HasColumnName("LastModifiedDate")
                .HasColumnOrder(3)
                .HasColumnType("datetime")
                .IsRequired();

            // LastModifiedBy property configuration
            _this.Property(prop => prop.LastModifiedBy)
                .HasColumnName("LastModifiedBy")
                .HasColumnOrder(4)
                .HasColumnType("bigint")
                .IsRequired();

            // Uid property configuration
            _this.Property(prop => prop.Uid)
                .HasColumnName("Uid")
                .HasColumnOrder(5)
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            // IsDeleted property configuration
            _this.Property(prop => prop.IsDeleted)
                .HasColumnName("IsDeleted")
                .HasColumnType("bit")
                .IsRequired();

            // IsActive property configuration
            _this.Property(prop => prop.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
