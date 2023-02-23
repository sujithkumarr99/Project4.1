using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Jayvankal.Models;

namespace Jayvankal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
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
    public IActionResult AboutUs()
    {
        return View();
    }
    public IActionResult Courses()
    {
        return View();
    }
    public IActionResult Facilities()
    {
        return View();
    }
    public IActionResult TeachingMethod()
    {
        return View();
    }
    public IActionResult Testimonials()
    {
        return View();
    }
    public IActionResult Culture()
    {
        return View();
    }
    public IActionResult Admission()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

