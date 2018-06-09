namespace Sandbox_ASP.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToTVShow : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TVShows", name: "Genre_Id", newName: "GenreId");
            RenameColumn(table: "dbo.TVShows", name: "TVWatcher_Id", newName: "TVWatcherId");
            RenameIndex(table: "dbo.TVShows", name: "IX_TVWatcher_Id", newName: "IX_TVWatcherId");
            RenameIndex(table: "dbo.TVShows", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.TVShows", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.TVShows", name: "IX_TVWatcherId", newName: "IX_TVWatcher_Id");
            RenameColumn(table: "dbo.TVShows", name: "TVWatcherId", newName: "TVWatcher_Id");
            RenameColumn(table: "dbo.TVShows", name: "GenreId", newName: "Genre_Id");
        }
    }
}
