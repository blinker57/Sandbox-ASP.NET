using Microsoft.AspNet.Identity;
using Sandbox_ASP.NET.Models;
using System.Linq;
using System.Web.Http;

namespace Sandbox_ASP.NET.Controllers
{
  public class AttendanceDto
  {
    public int TVShowId { get; set; }
  }

  [Authorize]
  public class AttendancesController : ApiController
  {
    private ApplicationDbContext _context;

    public AttendancesController()
    {
      _context = new ApplicationDbContext();
    }

    [HttpPost]
    public IHttpActionResult Attend(AttendanceDto dto)
    {
      var userId = User.Identity.GetUserId();

      if (_context.Attendances.Any(a => a.AttendeeId == userId && a.TVShowId == dto.TVShowId))
      {
        return BadRequest("The Attendance already exists.");
      }

      var attendance = new Attendance
      {
        TVShowId = dto.TVShowId,
        AttendeeId = userId
      };

      _context.Attendances.Add(attendance);
      _context.SaveChanges();

      return Ok();
    }
  }
}
