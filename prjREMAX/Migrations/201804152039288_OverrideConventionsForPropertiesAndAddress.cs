namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForPropertiesAndAddress : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Properties", "Address_Id", "dbo.Addresses");
            DropForeignKey("dbo.Properties", "Manager_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Properties", "Status_Id", "dbo.PropertyStatus");
            DropForeignKey("dbo.Properties", "Type_Id", "dbo.PropertyTypes");
            DropIndex("dbo.Properties", new[] { "Address_Id" });
            DropIndex("dbo.Properties", new[] { "Manager_Id" });
            DropIndex("dbo.Properties", new[] { "Status_Id" });
            DropIndex("dbo.Properties", new[] { "Type_Id" });
            AlterColumn("dbo.Properties", "PropertyName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Properties", "Description", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Properties", "Address_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Properties", "Manager_Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Properties", "Status_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Properties", "Type_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.PropertyStatus", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.PropertyTypes", "Name", c => c.String(nullable: false, maxLength: 255));
            CreateIndex("dbo.Properties", "Address_Id");
            CreateIndex("dbo.Properties", "Manager_Id");
            CreateIndex("dbo.Properties", "Status_Id");
            CreateIndex("dbo.Properties", "Type_Id");
            AddForeignKey("dbo.Properties", "Address_Id", "dbo.Addresses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Properties", "Manager_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Properties", "Status_Id", "dbo.PropertyStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Properties", "Type_Id", "dbo.PropertyTypes", "Id", cascadeDelete: true);
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
            AlterColumn("dbo.PropertyTypes", "Name", c => c.String());
            AlterColumn("dbo.PropertyStatus", "Name", c => c.String());
            AlterColumn("dbo.Properties", "Type_Id", c => c.Byte());
            AlterColumn("dbo.Properties", "Status_Id", c => c.Byte());
            AlterColumn("dbo.Properties", "Manager_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.Properties", "Address_Id", c => c.Int());
            AlterColumn("dbo.Properties", "Description", c => c.String());
            AlterColumn("dbo.Properties", "PropertyName", c => c.String());
            CreateIndex("dbo.Properties", "Type_Id");
            CreateIndex("dbo.Properties", "Status_Id");
            CreateIndex("dbo.Properties", "Manager_Id");
            CreateIndex("dbo.Properties", "Address_Id");
            AddForeignKey("dbo.Properties", "Type_Id", "dbo.PropertyTypes", "Id");
            AddForeignKey("dbo.Properties", "Status_Id", "dbo.PropertyStatus", "Id");
            AddForeignKey("dbo.Properties", "Manager_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Properties", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
