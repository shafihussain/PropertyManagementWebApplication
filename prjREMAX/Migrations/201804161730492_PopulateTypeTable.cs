namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (1, 'Building')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (2, 'Apartment')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (3, 'Penthouse')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (4, 'Townhouse')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (5, 'Condo')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (6, 'Studio')");
            Sql("INSERT INTO PropertyTypes (Id, Name) VALUES (7, 'Mansion')");

        }

        public override void Down()
        {
            Sql("DELETE FROM PropertyTypes WHERE Id IN (1, 2, 3, 4, 5, 6, 7)");
        }
    }
}
