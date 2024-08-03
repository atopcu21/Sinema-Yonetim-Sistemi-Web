using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sinema_Yonetim_Sistemi_mvc.Models;

namespace Sinema_Yonetim_Sistemi_mvc.Controllers;

public class MovieController : Controller
{
    private readonly ILogger<MovieController> _logger;

    public MovieController(ILogger<MovieController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
