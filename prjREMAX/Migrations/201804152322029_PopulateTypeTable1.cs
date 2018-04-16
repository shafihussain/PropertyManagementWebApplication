namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypeTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (3, 'Condo')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (4, 'Townhouse')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (5, 'Studio')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (6, 'Penthouse')");
        }

        public override void Down()
        {
            Sql("DELETE FROM PropertyTypes WHERE Id IN (3, 4, 5, 6)");
        }
    }
}
