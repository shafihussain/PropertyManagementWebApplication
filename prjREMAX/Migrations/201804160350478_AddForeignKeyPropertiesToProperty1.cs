namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToProperty1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Properties", name: "Address_Id", newName: "AddressId");
            RenameColumn(table: "dbo.Properties", name: "Type_Id", newName: "TypeId");
            RenameIndex(table: "dbo.Properties", name: "IX_Address_Id", newName: "IX_AddressId");
            RenameIndex(table: "dbo.Properties", name: "IX_Type_Id", newName: "IX_TypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Properties", name: "IX_TypeId", newName: "IX_Type_Id");
            RenameIndex(table: "dbo.Properties", name: "IX_AddressId", newName: "IX_Address_Id");
            RenameColumn(table: "dbo.Properties", name: "TypeId", newName: "Type_Id");
            RenameColumn(table: "dbo.Properties", name: "AddressId", newName: "Address_Id");
        }
    }
}
