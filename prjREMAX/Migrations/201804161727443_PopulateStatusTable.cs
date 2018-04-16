namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatusTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PropertyStatus (Id, Name) VALUES (1, 'Available')");
            Sql("INSERT INTO PropertyStatus (Id, Name) VALUES (2, 'Unvailable')");
            Sql("INSERT INTO PropertyStatus (Id, Name) VALUES (3, 'Seasonal')");

        }

        public override void Down()
        {
            Sql("DELETE FROM PropertyStatus WHERE Id IN (1, 2, 3)");
        }
    }
}
