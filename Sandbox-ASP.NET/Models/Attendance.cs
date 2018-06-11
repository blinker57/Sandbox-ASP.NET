using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sandbox_ASP.NET.Models
{
  public class Attendance
  {
    public TVShow TVShow { get; set; }
    public ApplicationUser Attendee { get; set; }

    [Key]
    [Column(Order = 1)]
    public int TVShowId { get; set; }

    [Key]
    [Column(Order = 2)]
    public string AttendeeId { get; set; }
  }
}