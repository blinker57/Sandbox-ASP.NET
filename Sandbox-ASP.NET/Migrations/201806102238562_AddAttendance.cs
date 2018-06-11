namespace Sandbox_ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        TVShowId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.TVShowId, t.AttendeeId })
                .ForeignKey("dbo.AspNetUsers", t => t.AttendeeId, cascadeDelete: true)
                .ForeignKey("dbo.TVShows", t => t.TVShowId)
                .Index(t => t.TVShowId)
                .Index(t => t.AttendeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "TVShowId", "dbo.TVShows");
            DropForeignKey("dbo.Attendances", "AttendeeId", "dbo.AspNetUsers");
            DropIndex("dbo.Attendances", new[] { "AttendeeId" });
            DropIndex("dbo.Attendances", new[] { "TVShowId" });
            DropTable("dbo.Attendances");
        }
    }
}
