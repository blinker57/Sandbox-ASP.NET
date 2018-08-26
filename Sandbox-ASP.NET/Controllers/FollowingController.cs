using Microsoft.AspNet.Identity;
using Sandbox_ASP.NET.Dtos;
using Sandbox_ASP.NET.Models;
using System.Linq;
using System.Web.Http;

namespace Sandbox_ASP.NET.Controllers
{
  [Authorize]
  public class FollowingController : ApiController
  {
    private ApplicationDbContext _context;

    public FollowingController()
    {
      _context = new ApplicationDbContext();
    }

    [HttpPost]
    public IHttpActionResult Follow(FollowingDto dto)
    {
      var userId = User.Identity.GetUserId();

      if (_context.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == dto.FolloweeId))
        return BadRequest("Following already exists.");

      var following = new Following
      {
        FollowerId = userId,
        FolloweeId = dto.FolloweeId
      };

      _context.Followings.Add(following);
      _context.SaveChanges();

      return Ok();
    }
  }
}
