using System;
using System.ComponentModel.DataAnnotations;

namespace Sandbox_ASP.NET.Models
{
  public class TVShow
  {
    public int Id { get; set; }

    public ApplicationUser TVWatcher { get; set; }

    [Required]
    public string TVWatcherId { get; set; }

    public DateTime DateTime { get; set; }

    [Required]
    [StringLength(255)]
    public string Network { get; set; }

    public Genre Genre { get; set; }

    [Required]
    public byte GenreId { get; set; }
  }
}