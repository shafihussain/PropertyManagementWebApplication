namespace prjREMAX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateModelAppointment : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "AppointmentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Appointments", new[] { "PropertyId", "AppointmentId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Appointments");
            AlterColumn("dbo.Appointments", "AppointmentId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Appointments", new[] { "PropertyId", "AppointmentId" });
        }
    }
}
