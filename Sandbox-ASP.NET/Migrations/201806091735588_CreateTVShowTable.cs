namespace Sandbox_ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTVShowTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TVShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Network = c.String(),
                        Genre_Id = c.Byte(),
                        TVWatcher_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.TVWatcher_Id)
                .Index(t => t.Genre_Id)
                .Index(t => t.TVWatcher_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TVShows", "TVWatcher_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TVShows", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.TVShows", new[] { "TVWatcher_Id" });
            DropIndex("dbo.TVShows", new[] { "Genre_Id" });
            DropTable("dbo.TVShows");
            DropTable("dbo.Genres");
        }
    }
}
