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
        }
        
        public override void Down()
        {
            Sql("DELETE FROM PropertyTypes WHERE Id IN (1, 2)");
        }
    }
}
