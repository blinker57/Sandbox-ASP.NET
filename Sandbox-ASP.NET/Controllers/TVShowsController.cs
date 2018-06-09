using Microsoft.AspNet.Identity;
using Sandbox_ASP.NET.Models;
using Sandbox_ASP.NET.ViewModels;
using System;
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
    public ActionResult Create(TVShowViewModel viewModel)
    {
      var show = new TVShow
      {
        TVWatcherId = User.Identity.GetUserId(),
        DateTime = viewModel.DateTime,
        GenreId = viewModel.Genre,
        Network = viewModel.Network
      };

      _context.TVShows.Add(show);
      _context.SaveChanges();

      return RedirectToAction("Index", "Home");
    }
  }
}