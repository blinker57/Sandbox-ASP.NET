
using Sandbox_ASP.NET.Models;
using System.Collections.Generic;

namespace Sandbox_ASP.NET.ViewModels
{
  public class TVShowViewModel
  {
    public string Network { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public byte Genre { get; set; }
    public IEnumerable<Genre> Genres { get; set; }
  }
}