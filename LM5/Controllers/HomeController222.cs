using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LaudaMusicam.Models;

namespace LaudaMusicam.Controllers;

public class Home222Controller : Controller
{
    private readonly ILogger<Home222Controller> _logger;

    public Home222Controller(ILogger<Home222Controller> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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

