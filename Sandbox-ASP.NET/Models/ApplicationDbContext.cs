using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace Sandbox_ASP.NET.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<TVShow> TVShows { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public override IDbSet<ApplicationUser> Users { get => base.Users; set => base.Users = value; }
    public override IDbSet<IdentityRole> Roles { get => base.Roles; set => base.Roles = value; }

    public ApplicationDbContext()
          : base("DefaultConnection", throwIfV1Schema: false)
    {
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }

    public override DbSet<TEntity> Set<TEntity>()
    {
      return base.Set<TEntity>();
    }

    public override DbSet Set(Type entityType)
    {
      return base.Set(entityType);
    }

    public override int SaveChanges()
    {
      return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync()
    {
      return base.SaveChangesAsync();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
      return base.SaveChangesAsync(cancellationToken);
    }

    protected override bool ShouldValidateEntity(DbEntityEntry entityEntry)
    {
      return base.ShouldValidateEntity(entityEntry);
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Attendance>()
          .HasRequired(a => a.TVShow)
          .WithMany()
          .WillCascadeOnDelete(false);
      base.OnModelCreating(modelBuilder);
    }
  }
}