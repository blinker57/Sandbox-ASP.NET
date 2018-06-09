using System.ComponentModel.DataAnnotations;

namespace Sandbox_ASP.NET.Models
{
  public class Genre
  {
    public byte Id { get; set; }

    [Required]
    [StringLength(32)]
    public string Name { get; set; }
  }
}
