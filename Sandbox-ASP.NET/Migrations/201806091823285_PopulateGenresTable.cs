namespace Sandbox_ASP.NET.Migrations
{
  using System.Data.Entity.Migrations;

  public partial class PopulateGenresTable : DbMigration
  {
    public override void Up()
    {
      Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Animation')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Biography')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Comedy')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Crime')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Documentary')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Drama')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Family')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Fantasy')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Games Show')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'History')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Horror')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Music')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (15, 'Musical')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (16, 'Mystery')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (17, 'News')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (18, 'Reality-TV')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (19, 'Romance')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (20, 'Sci-Fi')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (21, 'Sport')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (22, 'Superhero')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (23, 'Talk Show')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (24, 'Thriller')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (25, 'War')");
      Sql("INSERT INTO Genres (Id, Name) VALUES (26, 'Western')");
    }

    public override void Down()
    {
      Sql("DELETE FROM Genres WHERE Id BETWEEN 1 and 26");
    }
  }
}
