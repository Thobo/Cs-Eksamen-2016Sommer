namespace Formel1.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverId = c.Int(nullable: false, identity: true),
                        DriverName = c.String(),
                        Age = c.Int(nullable: false),
                        Country = c.String(),
                        TeamId = c.Int(nullable: false),
                        Driver_DriverId = c.Int(),
                    })
                .PrimaryKey(t => t.DriverId)
                .ForeignKey("dbo.Drivers", t => t.Driver_DriverId)
                .Index(t => t.Driver_DriverId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "Driver_DriverId", "dbo.Drivers");
            DropIndex("dbo.Drivers", new[] { "Driver_DriverId" });
            DropTable("dbo.Drivers");
        }
    }
}
