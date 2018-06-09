
using Sandbox_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sandbox_ASP.NET.ViewModels
{
  public class TVShowViewModel
  {
    [Required]
    public string Network { get; set; }

    [Required]
    [FutureDate]
    public string Date { get; set; }

    [Required]
    [ValidTime]
    public string Time { get; set; }

    [Required]
    public byte Genre { get; set; }

    public IEnumerable<Genre> Genres { get; set; }

    public DateTime GetDateTime()
    {
      return DateTime.Parse(string.Format("{0} {1}", Date, Time));
    }
  }
}