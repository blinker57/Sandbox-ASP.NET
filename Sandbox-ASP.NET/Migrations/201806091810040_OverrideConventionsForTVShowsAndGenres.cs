namespace Sandbox_ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OverrideConventionsForTVShowsAndGenres : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TVShows", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.TVShows", "TVWatcher_Id", "dbo.AspNetUsers");
            DropIndex("dbo.TVShows", new[] { "Genre_Id" });
            DropIndex("dbo.TVShows", new[] { "TVWatcher_Id" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 32));
            AlterColumn("dbo.TVShows", "Network", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.TVShows", "Genre_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.TVShows", "TVWatcher_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.TVShows", "Genre_Id");
            CreateIndex("dbo.TVShows", "TVWatcher_Id");
            AddForeignKey("dbo.TVShows", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.TVShows", "TVWatcher_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TVShows", "TVWatcher_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TVShows", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.TVShows", new[] { "TVWatcher_Id" });
            DropIndex("dbo.TVShows", new[] { "Genre_Id" });
            AlterColumn("dbo.TVShows", "TVWatcher_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.TVShows", "Genre_Id", c => c.Byte());
            AlterColumn("dbo.TVShows", "Network", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.TVShows", "TVWatcher_Id");
            CreateIndex("dbo.TVShows", "Genre_Id");
            AddForeignKey("dbo.TVShows", "TVWatcher_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.TVShows", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
