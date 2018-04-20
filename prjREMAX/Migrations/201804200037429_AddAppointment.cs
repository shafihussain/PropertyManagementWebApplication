namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppointment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        PropertyId = c.Int(nullable: false),
                        AppointmentId = c.Int(nullable: false),
                        PotentialBuyer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PropertyId, t.AppointmentId })
                .ForeignKey("dbo.AspNetUsers", t => t.PotentialBuyer_Id)
                .ForeignKey("dbo.Properties", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId)
                .Index(t => t.PotentialBuyer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PropertyId", "dbo.Properties");
            DropForeignKey("dbo.Appointments", "PotentialBuyer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Appointments", new[] { "PotentialBuyer_Id" });
            DropIndex("dbo.Appointments", new[] { "PropertyId" });
            DropTable("dbo.Appointments");
        }
    }
}
