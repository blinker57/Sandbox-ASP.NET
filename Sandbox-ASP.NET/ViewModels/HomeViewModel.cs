using Sandbox_ASP.NET.Models;
using System.Collections.Generic;

namespace Sandbox_ASP.NET.ViewModels
{
  public class HomeViewModel
  {
    public IEnumerable<TVShow> UpcomingShows { get; set; }
    public bool ShowActions { get; set; }
  }
}
