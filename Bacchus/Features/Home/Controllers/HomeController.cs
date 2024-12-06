using Microsoft.AspNetCore.Mvc;

namespace Bacchus.Features.Home.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult NoCompression() => View();

    public IActionResult BrotliCompression() => View();

    public IActionResult GzipCompression() => View();
}