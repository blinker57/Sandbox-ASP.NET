using Microsoft.AspNet.Identity;
using Sandbox_ASP.NET.Models;
using Sandbox_ASP.NET.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Sandbox_ASP.NET.Controllers
{
  public class TVShowsController : Controller
  {
    private readonly ApplicationDbContext _context;

    public TVShowsController()
    {
      _context = new ApplicationDbContext();
    }

    public ActionResult Attending()
    {
      var userId = User.Identity.GetUserId();
      var tvshows = _context.Attendances
          .Where(a => a.AttendeeId == userId)
          .Select(a => a.TVShow)
          .Include(t => t.TVWatcher)
          .Include(t => t.Genre)
          .ToList();

      var viewModel = new HomeViewModel()
      {
        UpcomingShows = tvshows,
        ShowActions = User.Identity.IsAuthenticated
      };

      return View(viewModel);
    }

    [Authorize]
    public ActionResult Create()
    {
      var viewModel = new TVShowViewModel
      {
        Genres = _context.Genres.ToList()
      };

      return View(viewModel);
    }

    [Authorize]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(TVShowViewModel viewModel)
    {
      if (!ModelState.IsValid)
      {
        viewModel.Genres = _context.Genres.ToList();
        return View("Create", viewModel);
      }

      var show = new TVShow
      {
        TVWatcherId = User.Identity.GetUserId(),
        DateTime = viewModel.GetDateTime(),
        GenreId = viewModel.Genre,
        Network = viewModel.Network
      };

      _context.TVShows.Add(show);
      _context.SaveChanges();

      return RedirectToAction("Index", "Home");
    }
  }
}