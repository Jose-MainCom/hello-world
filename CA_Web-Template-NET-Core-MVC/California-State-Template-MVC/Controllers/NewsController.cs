using Microsoft.AspNetCore.Mvc;

namespace California_State_Template_MVC.Controllers;

[Route("about/news")]
public class NewsController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("articles")]
    public IActionResult Articles()
    {
        return View();
    }

    [HttpGet("article-title1")]
    public IActionResult ArticleTitle1()
    {
        return View();
    }

    [HttpGet("article-title2")]
    public IActionResult ArticleTitle2()
    {
        return View();
    }

    [HttpGet("article-title3")]
    public IActionResult ArticleTitle3()
    {
        return View();
    }

    [HttpGet("blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [HttpGet("blog-title1")]
    public IActionResult BlogTitle1()
    {
        return View();
    }

    [HttpGet("blog-title2")]
    public IActionResult BlogTitle2()
    {
        return View();
    }

    [HttpGet("press-information")]
    public IActionResult PressInformation()
    {
        return View();
    }

    [HttpGet("press-releases")]
    public IActionResult PressReleases()
    {
        return View();
    }

    [HttpGet("press-release-title1")]
    public IActionResult PressReleaseTitle1()
    {
        return View();
    }

    [HttpGet("press-release-title2")]
    public IActionResult PressReleaseTitle2()
    {
        return View();
    }

    [HttpGet("subscription-services")]
    public IActionResult SubscriptionServices()
    {
        return View();
    }
}

