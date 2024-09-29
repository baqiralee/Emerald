namespace Emerald.DbConfiguration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "emerald.AccommodationPackages",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.Long(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.Long(nullable: false),
                        Uid = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        AccommodationTypeID = c.Int(nullable: false),
                        RoomQuantity = c.Int(nullable: false),
                        Charges = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "emerald.Accommodations",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.Long(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.Long(nullable: false),
                        Uid = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        AccommodationPackageId = c.Long(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("emerald.AccommodationPackages", t => t.AccommodationPackageId)
                .Index(t => t.AccommodationPackageId);
            
            CreateTable(
                "emerald.Bookings",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                        CreatedBy = c.Long(nullable: false),
                        LastModifiedDate = c.DateTime(nullable: false),
                        LastModifiedBy = c.Long(nullable: false),
                        Uid = c.Guid(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                        AccommodationId = c.Long(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("emerald.Accommodations", t => t.AccommodationId)
                .Index(t => t.AccommodationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("emerald.Accommodations", "AccommodationPackageId", "emerald.AccommodationPackages");
            DropForeignKey("emerald.Bookings", "AccommodationId", "emerald.Accommodations");
            DropIndex("emerald.Bookings", new[] { "AccommodationId" });
            DropIndex("emerald.Accommodations", new[] { "AccommodationPackageId" });
            DropTable("emerald.Bookings");
            DropTable("emerald.Accommodations");
            DropTable("emerald.AccommodationPackages");
        }
    }
}
