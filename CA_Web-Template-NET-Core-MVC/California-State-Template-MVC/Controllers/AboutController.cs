using Microsoft.AspNetCore.Mvc;

namespace California_State_Template_MVC.Controllers;

public class AboutController : Controller
{
    [HttpGet("about")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("about/our-organization")]
    public IActionResult OurOrganization()
    {
        return View();
    }

    [HttpGet("about/careers")]
    public IActionResult Careers()
    {
        return View();
    }
}

