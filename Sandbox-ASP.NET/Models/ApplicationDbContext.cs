using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Sandbox_ASP.NET.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<TVShow> TVShows { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public ApplicationDbContext()
          : base("DefaultConnection", throwIfV1Schema: false)
    {
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }
  }
}