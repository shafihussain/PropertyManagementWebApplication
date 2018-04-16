namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToProperty : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Properties", name: "Manager_Id", newName: "ManagerId");
            RenameColumn(table: "dbo.Properties", name: "Status_Id", newName: "StatusId");
            RenameIndex(table: "dbo.Properties", name: "IX_Manager_Id", newName: "IX_ManagerId");
            RenameIndex(table: "dbo.Properties", name: "IX_Status_Id", newName: "IX_StatusId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Properties", name: "IX_StatusId", newName: "IX_Status_Id");
            RenameIndex(table: "dbo.Properties", name: "IX_ManagerId", newName: "IX_Manager_Id");
            RenameColumn(table: "dbo.Properties", name: "StatusId", newName: "Status_Id");
            RenameColumn(table: "dbo.Properties", name: "ManagerId", newName: "Manager_Id");
        }
    }
}
