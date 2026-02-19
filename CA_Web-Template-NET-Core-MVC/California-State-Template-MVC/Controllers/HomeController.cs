using California_State_Template_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace California_State_Template_MVC.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("components-patterns")]
    public IActionResult ComponentsPatterns()
    {
        return View();
    }

    [HttpGet("contact")]
    [HttpGet("contact-us")]
    public IActionResult Contact()
    {
        return View();
    }

    [HttpGet("content-directory")]
    public IActionResult ContentDirectory()
    {
        return View();
    }

    [HttpGet("conditions-of-use")]
    public IActionResult ConditionsOfUse()
    {
        return View();
    }

    [HttpGet("privacy-policy")]
    public IActionResult PrivacyPolicy()
    {
        return View();
    }

    [HttpGet("accessibility")]
    public IActionResult Accessibility()
    {
        return View();
    }

    [HttpGet("website-accessibility-certification")]
    public IActionResult WebsiteAccessibilityCertification()
    {
        return View();
    }

    [HttpGet("sitemap")]
    public IActionResult Sitemap()
    {
        return View();
    }

    [HttpGet("serp")]
    public IActionResult Serp()
    {
        return View();
    }

    [HttpGet("404")]
    public IActionResult Page404()
    {
        Response.StatusCode = StatusCodes.Status404NotFound;
        return View();
    }

    [HttpGet("cagov-header")]
    public IActionResult CagovHeader()
    {
        return View();
    }

    [HttpGet("cagov-utility")]
    public IActionResult CagovUtility()
    {
        return View();
    }

    [HttpGet("cagov-header-full")]
    public IActionResult CagovHeaderFull()
    {
        return View();
    }

    [HttpGet("cagov-footer")]
    public IActionResult CagovFooter()
    {
        return View();
    }

    [HttpGet("template-header-full")]
    public IActionResult TemplateHeaderFull()
    {
        return View();
    }

    [HttpGet("blank")]
    public IActionResult Blank()
    {
        return View();
    }

    [HttpGet("newsroom")]
    public IActionResult Newsroom()
    {
        return RedirectToAction(nameof(NewsController.Index), "News");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

