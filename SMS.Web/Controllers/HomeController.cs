using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var longDate = DateTime.Now.ToLongDateString();
        var longTime = DateTime.Now.ToLongTimeString();

        ViewBag.LongDate = longDate;
        ViewBag.LongTime = longTime;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        var title = "This is a title";
        var message = "This is a message";
        var company = "Bond Technologies";

        var about = new AboutViewModel {
            Formed = new DateTime(2022, 6, 25),
            Title = title,
            Message = message,
            Company = company
        };

        return View(about);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
