using Microsoft.AspNetCore.Mvc;

namespace California_State_Template_MVC.Controllers;

[Route("top-task-2")]
public class TopTask2Controller : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("content-page-1")]
    public IActionResult ContentPage1()
    {
        return View();
    }

    [HttpGet("content-page-2")]
    public IActionResult ContentPage2()
    {
        return View();
    }

    [HttpGet("content-page-3")]
    public IActionResult ContentPage3()
    {
        return RedirectToAction(nameof(ContentPage2));
    }
}

