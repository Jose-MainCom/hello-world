using Microsoft.AspNetCore.Mvc;

namespace California_State_Template_MVC.Controllers;

[Route("top-task-1")]
public class TopTask1Controller : Controller
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
        return View();
    }

    [HttpGet("content-page-4")]
    public IActionResult ContentPage4()
    {
        return View();
    }
}

