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
        return View();
    }

    [HttpGet("about")]
    public IActionResult About()
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

    [HttpGet("about/news")]
    public IActionResult AboutNews()
    {
        return View();
    }

    [HttpGet("about/news/articles")]
    public IActionResult Articles()
    {
        return View();
    }

    [HttpGet("about/news/article-title1")]
    public IActionResult ArticleTitle1()
    {
        return View();
    }

    [HttpGet("about/news/article-title2")]
    public IActionResult ArticleTitle2()
    {
        return View();
    }

    [HttpGet("about/news/article-title3")]
    public IActionResult ArticleTitle3()
    {
        return View();
    }

    [HttpGet("about/news/blog")]
    public IActionResult Blog()
    {
        return View();
    }

    [HttpGet("about/news/blog-title1")]
    public IActionResult BlogTitle1()
    {
        return View();
    }

    [HttpGet("about/news/blog-title2")]
    public IActionResult BlogTitle2()
    {
        return View();
    }

    [HttpGet("about/news/press-information")]
    public IActionResult PressInformation()
    {
        return View();
    }

    [HttpGet("about/news/press-releases")]
    public IActionResult PressReleases()
    {
        return View();
    }

    [HttpGet("about/news/press-release-title1")]
    public IActionResult PressReleaseTitle1()
    {
        return View();
    }

    [HttpGet("about/news/press-release-title2")]
    public IActionResult PressReleaseTitle2()
    {
        return View();
    }

    [HttpGet("about/news/subscription-services")]
    public IActionResult SubscriptionServices()
    {
        return View();
    }

    [HttpGet("top-task-1")]
    public IActionResult TopTask1()
    {
        return View();
    }

    [HttpGet("top-task-1/content-page-1")]
    public IActionResult TopTask1ContentPage1()
    {
        return View();
    }

    [HttpGet("top-task-1/content-page-2")]
    public IActionResult TopTask1ContentPage2()
    {
        return View();
    }

    [HttpGet("top-task-1/content-page-3")]
    public IActionResult TopTask1ContentPage3()
    {
        return View();
    }

    [HttpGet("top-task-1/content-page-4")]
    public IActionResult TopTask1ContentPage4()
    {
        return View();
    }

    [HttpGet("top-task-2")]
    public IActionResult TopTask2()
    {
        return View();
    }

    [HttpGet("top-task-2/content-page-1")]
    public IActionResult TopTask2ContentPage1()
    {
        return View();
    }

    [HttpGet("top-task-2/content-page-2")]
    public IActionResult TopTask2ContentPage2()
    {
        return View();
    }

    [HttpGet("top-task-2/content-page-3")]
    public IActionResult TopTask2ContentPage3()
    {
        return View();
    }

    [HttpGet("samples/accordion")]
    public IActionResult Accordion()
    {
        return View();
    }

    [HttpGet("samples/accordion-list")]
    public IActionResult AccordionList()
    {
        return View();
    }

    [HttpGet("samples/accordion-side-navigation")]
    public IActionResult AccordionSideNavigation()
    {
        return View();
    }

    [HttpGet("samples/alert")]
    public IActionResult Alert()
    {
        return View();
    }

    [HttpGet("samples/alert-banner")]
    public IActionResult AlertBanner()
    {
        return View();
    }

    [HttpGet("samples/banner")]
    public IActionResult Banner()
    {
        return View();
    }

    [HttpGet("samples/blockquote")]
    public IActionResult Blockquote()
    {
        return View();
    }

    [HttpGet("samples/blockquote-no-graphic")]
    public IActionResult BlockquoteNoGraphic()
    {
        return View();
    }

    [HttpGet("samples/blockquote-prominent")]
    public IActionResult BlockquoteProminent()
    {
        return View();
    }

    [HttpGet("samples/blockquote-pull")]
    public IActionResult BlockquotePull()
    {
        return View();
    }

    [HttpGet("samples/blockquote-with-image")]
    public IActionResult BlockquoteWithImage()
    {
        return View();
    }

    [HttpGet("samples/bootstrap-side-navigation-primary")]
    public IActionResult BootstrapSideNavigationPrimary()
    {
        return View();
    }

    [HttpGet("samples/breadcrumb")]
    public IActionResult Breadcrumb()
    {
        return View();
    }

    [HttpGet("samples/buttons")]
    public IActionResult Buttons()
    {
        return View();
    }

    [HttpGet("samples/buttons-disabled")]
    public IActionResult ButtonsDisabled()
    {
        return View();
    }

    [HttpGet("samples/buttons-hover")]
    public IActionResult ButtonsHover()
    {
        return View();
    }

    [HttpGet("samples/buttons-outline")]
    public IActionResult ButtonsOutline()
    {
        return View();
    }

    [HttpGet("samples/buttons-sizes")]
    public IActionResult ButtonsSizes()
    {
        return View();
    }

    [HttpGet("samples/card-default")]
    public IActionResult CardDefault()
    {
        return View();
    }

    [HttpGet("samples/card-grid-basic")]
    public IActionResult CardGridBasic()
    {
        return View();
    }

    [HttpGet("samples/card-grid-icons")]
    public IActionResult CardGridIcons()
    {
        return View();
    }

    [HttpGet("samples/card-grid-images")]
    public IActionResult CardGridImages()
    {
        return View();
    }

    [HttpGet("samples/card-icon")]
    public IActionResult CardIcon()
    {
        return View();
    }

    [HttpGet("samples/card-image")]
    public IActionResult CardImage()
    {
        return View();
    }

    [HttpGet("samples/card-legacy")]
    public IActionResult CardLegacy()
    {
        return View();
    }

    [HttpGet("samples/countdown-timer")]
    public IActionResult CountdownTimer()
    {
        return View();
    }

    [HttpGet("samples/executive-profile")]
    public IActionResult ExecutiveProfile()
    {
        return View();
    }

    [HttpGet("samples/executive-profile-dark")]
    public IActionResult ExecutiveProfileDark()
    {
        return View();
    }

    [HttpGet("samples/executive-profile-transparent")]
    public IActionResult ExecutiveProfileTransparent()
    {
        return View();
    }

    [HttpGet("samples/external-links")]
    public IActionResult ExternalLinks()
    {
        return View();
    }

    [HttpGet("samples/feature-card")]
    public IActionResult FeatureCard()
    {
        return View();
    }

    [HttpGet("samples/featured-search")]
    public IActionResult FeaturedSearch()
    {
        return View();
    }

    [HttpGet("samples/form-checkbox")]
    public IActionResult FormCheckbox()
    {
        return View();
    }

    [HttpGet("samples/form-dropdown")]
    public IActionResult FormDropdown()
    {
        return View();
    }

    [HttpGet("samples/form-file-input")]
    public IActionResult FormFileInput()
    {
        return View();
    }

    [HttpGet("samples/form-label")]
    public IActionResult FormLabel()
    {
        return View();
    }

    [HttpGet("samples/form-radio")]
    public IActionResult FormRadio()
    {
        return View();
    }

    [HttpGet("samples/form-textarea")]
    public IActionResult FormTextarea()
    {
        return View();
    }

    [HttpGet("samples/form-textarea-required")]
    public IActionResult FormTextareaRequired()
    {
        return View();
    }

    [HttpGet("samples/form-textfield")]
    public IActionResult FormTextfield()
    {
        return View();
    }

    [HttpGet("samples/form-textfield-required")]
    public IActionResult FormTextfieldRequired()
    {
        return View();
    }

    [HttpGet("samples/gradient-linear")]
    public IActionResult GradientLinear()
    {
        return View();
    }

    [HttpGet("samples/gradient-radial")]
    public IActionResult GradientRadial()
    {
        return View();
    }

    [HttpGet("samples/header-primary-banner")]
    public IActionResult HeaderPrimaryBanner()
    {
        return View();
    }

    [HttpGet("samples/horizontal-separator")]
    public IActionResult HorizontalSeparator()
    {
        return View();
    }

    [HttpGet("samples/link-grid")]
    public IActionResult LinkGrid()
    {
        return View();
    }

    [HttpGet("samples/list-ordered")]
    public IActionResult ListOrdered()
    {
        return View();
    }

    [HttpGet("samples/list-unordered")]
    public IActionResult ListUnordered()
    {
        return View();
    }

    [HttpGet("samples/megamenu")]
    public IActionResult Megamenu()
    {
        return View();
    }

    [HttpGet("samples/modal")]
    public IActionResult Modal()
    {
        return View();
    }

    [HttpGet("samples/navigation-with-icons")]
    public IActionResult NavigationWithIcons()
    {
        return View();
    }

    [HttpGet("samples/nav-side-accordion")]
    public IActionResult NavSideAccordion()
    {
        return View();
    }

    [HttpGet("samples/news-article")]
    public IActionResult NewsArticle()
    {
        return View();
    }

    [HttpGet("samples/news-block")]
    public IActionResult NewsBlock()
    {
        return View();
    }

    [HttpGet("samples/news-cards")]
    public IActionResult NewsCards()
    {
        return View();
    }

    [HttpGet("samples/news-featured-banner")]
    public IActionResult NewsFeaturedBanner()
    {
        return View();
    }

    [HttpGet("samples/news-list")]
    public IActionResult NewsList()
    {
        return View();
    }

    [HttpGet("samples/news-list-extended")]
    public IActionResult NewsListExtended()
    {
        return View();
    }

    [HttpGet("samples/news-list-featured")]
    public IActionResult NewsListFeatured()
    {
        return View();
    }

    [HttpGet("samples/number-counter")]
    public IActionResult NumberCounter()
    {
        return View();
    }

    [HttpGet("samples/page-navigation")]
    public IActionResult PageNavigation()
    {
        return View();
    }

    [HttpGet("samples/page-navigation-more")]
    public IActionResult PageNavigationMore()
    {
        return View();
    }

    [HttpGet("samples/pagination")]
    public IActionResult Pagination()
    {
        return View();
    }

    [HttpGet("samples/progress-bar")]
    public IActionResult ProgressBar()
    {
        return View();
    }

    [HttpGet("samples/progress-block")]
    public IActionResult ProgressBlock()
    {
        return View();
    }

    [HttpGet("samples/progress-block-bold")]
    public IActionResult ProgressBlockBold()
    {
        return View();
    }

    [HttpGet("samples/section-primary")]
    public IActionResult SectionPrimary()
    {
        return View();
    }

    [HttpGet("samples/section-standout")]
    public IActionResult SectionStandout()
    {
        return View();
    }

    [HttpGet("samples/side-navigation")]
    public IActionResult SideNavigation()
    {
        return View();
    }

    [HttpGet("samples/side-navigation-level1")]
    public IActionResult SideNavigationLevel1()
    {
        return View();
    }

    [HttpGet("samples/side-navigation-level2")]
    public IActionResult SideNavigationLevel2()
    {
        return View();
    }

    [HttpGet("samples/side-navigation-level3")]
    public IActionResult SideNavigationLevel3()
    {
        return View();
    }

    [HttpGet("samples/site-footer")]
    public IActionResult SiteFooter()
    {
        return View();
    }

    [HttpGet("samples/site-header-sample-site")]
    public IActionResult SiteHeaderSampleSite()
    {
        return View();
    }

    [HttpGet("samples/site-header-sample-site-news")]
    public IActionResult SiteHeaderSampleSiteNews()
    {
        return View();
    }

    [HttpGet("samples/social-media-icons")]
    public IActionResult SocialMediaIcons()
    {
        return View();
    }

    [HttpGet("samples/step-list")]
    public IActionResult StepList()
    {
        return View();
    }

    [HttpGet("samples/table")]
    public IActionResult Table()
    {
        return View();
    }

    [HttpGet("samples/table-default")]
    public IActionResult TableDefault()
    {
        return View();
    }

    [HttpGet("samples/table-striped")]
    public IActionResult TableStriped()
    {
        return View();
    }

    [HttpGet("samples/tabs")]
    public IActionResult Tabs()
    {
        return View();
    }

    [HttpGet("samples/timeline")]
    public IActionResult Timeline()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
