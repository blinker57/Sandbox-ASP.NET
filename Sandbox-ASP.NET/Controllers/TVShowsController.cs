using Sandbox_ASP.NET.Models;
using Sandbox_ASP.NET.ViewModels;
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

    public ActionResult Create()
    {
      var viewModel = new TVShowViewModel
      {
        Genres = _context.Genres.ToList()
      };

      return View(viewModel);
    }
  }
}