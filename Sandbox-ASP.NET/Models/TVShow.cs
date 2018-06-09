using System;
using System.ComponentModel.DataAnnotations;

namespace Sandbox_ASP.NET.Models
{
  public class TVShow
  {
    public int Id { get; set; }

    [Required]
    public ApplicationUser TVWatcher { get; set; }

    public DateTime DateTime { get; set; }

    [Required]
    [StringLength(255)]
    public string Network { get; set; }

    [Required]
    public Genre Genre { get; set; }
  }
}