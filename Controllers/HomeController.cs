using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment_random_passcode.Models;
using Microsoft.AspNetCore.Http;

namespace assignment_random_passcode.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    Random rand = new Random();
    string myName = "";
    string newString = "";
    public IActionResult Index()
    {
      if (HttpContext.Session.GetString("name") == null)
      {
        Console.WriteLine("First Time Through");
        newString = "";
        HttpContext.Session.SetString("name", "Eric");
      }
      else
      {
        Console.WriteLine("Other Time Through");
        newString = "";
        for (int i = 0; i < 14; i++)
        {
          newString += "X";
          Console.Write(newString);
        }
        HttpContext.Session.SetString("name", newString);
      }
      myName = HttpContext.Session.GetString("name");
      ViewBag.SessionName = myName;

      return View("Index", myName);
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
