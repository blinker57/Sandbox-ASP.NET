using Sandbox_ASP.NET.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Sandbox_ASP.NET.Controllers
{
  public class HomeController : Controller
  {
    private ApplicationDbContext _context;

    public HomeController()
    {
      _context = new ApplicationDbContext();
    }

    public ActionResult Index()
    {
      var upcomingShows = _context.TVShows
            .Include(tv => tv.TVWatcher)
            .Where(tv => tv.DateTime > DateTime.Now);

      return View(upcomingShows);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}