namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePropertyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        PropertyName = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(),
                        Rooms = c.Int(nullable: false),
                        Bathrooms = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Address_Id = c.Int(),
                        Manager_Id = c.String(maxLength: 128),
                        Status_Id = c.Byte(),
                        Type_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.Addresses", t => t.Address_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Manager_Id)
                .ForeignKey("dbo.PropertyStatus", t => t.Status_Id)
                .ForeignKey("dbo.PropertyTypes", t => t.Type_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Manager_Id)
                .Index(t => t.Status_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CivicNumber = c.Int(nullable: false),
                        Street = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        Province = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyStatus",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PropertyTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Properties", "Type_Id", "dbo.PropertyTypes");
            DropForeignKey("dbo.Properties", "Status_Id", "dbo.PropertyStatus");
            DropForeignKey("dbo.Properties", "Manager_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Properties", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Properties", new[] { "Type_Id" });
            DropIndex("dbo.Properties", new[] { "Status_Id" });
            DropIndex("dbo.Properties", new[] { "Manager_Id" });
            DropIndex("dbo.Properties", new[] { "Address_Id" });
            DropTable("dbo.PropertyTypes");
            DropTable("dbo.PropertyStatus");
            DropTable("dbo.Addresses");
            DropTable("dbo.Properties");
        }
    }
}
