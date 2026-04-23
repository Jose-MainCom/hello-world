using California_State_Template_MVC.Models;
using California_State_Template_MVC.Models.Home;
using California_State_Template_MVC.Models.SampleSite.Components;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace California_State_Template_MVC.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View(BuildHomeIndexViewModel());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    private static HomeIndexViewModel BuildHomeIndexViewModel()
    {
        return new HomeIndexViewModel
        {
            ComponentLinks =
            [
                new ComponentLinkViewModel
                {
                    Title = "Alert",
                    Description = "Simple model binding and conditional content rendering.",
                    Url = "#alert-preview"
                },
                new ComponentLinkViewModel
                {
                    Title = "Accordion",
                    Description = "Collection rendering with reusable partials.",
                    Url = "#accordion-preview"
                },
                new ComponentLinkViewModel
                {
                    Title = "Card Grid",
                    Description = "List-driven UI with repeatable card content.",
                    Url = "#card-grid-preview"
                },
                new ComponentLinkViewModel
                {
                    Title = "Breadcrumb",
                    Description = "Route context expressed through a typed navigation model.",
                    Url = "#breadcrumb-preview"
                },
                new ComponentLinkViewModel
                {
                    Title = "Side Navigation",
                    Description = "Nested hierarchy rendering from a tree view model.",
                    Url = "#side-navigation-preview"
                }
            ],
            Alert = BuildAlertModel(),
            Accordion = BuildAccordionModel(),
            CardGrid = BuildCardGridModel(),
            Breadcrumb = BuildBreadcrumbModel(),
            SideNavigation = BuildSideNavModel()
        };
    }

    private static AlertComponentViewModel BuildAlertModel()
    {
        return new AlertComponentViewModel
        {
            EmphasisText = "New demo:",
            Message = "This sample shows MVC model-to-view rendering with reusable partials.",
            LinkText = "Jump to Card Grid",
            LinkUrl = "#card-grid-preview",
            IconImageUrl = "/images/alert-info.svg",
            IconImageAlt = "Information icon"
        };
    }

    private static AccordionComponentViewModel BuildAccordionModel()
    {
        return new AccordionComponentViewModel
        {
            Items =
            [
                new AccordionItemComponentViewModel
                {
                    Heading = "Reusable markup",
                    Paragraphs =
                    [
                        "MVC partials let you render the same component in multiple sections from one source.",
                        "The same accordion partial powers this entire one-page demo."
                    ]
                },
                new AccordionItemComponentViewModel
                {
                    Heading = "Typed models",
                    Paragraphs =
                    [
                        "Each component uses its own view model class.",
                        "Strong typing keeps rendering logic clean and easier to maintain."
                    ]
                },
                new AccordionItemComponentViewModel
                {
                    Heading = "Controller-driven data",
                    Paragraphs =
                    [
                        "The controller builds the model once and passes it into the Razor view.",
                        "This keeps component behavior explicit and testable."
                    ]
                }
            ]
        };
    }

    private static CardGridComponentViewModel BuildCardGridModel()
    {
        return new CardGridComponentViewModel
        {
            Cards =
            [
                new CardComponentViewModel
                {
                    Title = "Single-page action",
                    Body = "One Home/Index action builds the full page from strongly typed component view models.",
                    ButtonText = "Go to sections",
                    ButtonUrl = "#components",
                    ButtonSrOnlyText = "section"
                },
                new CardComponentViewModel
                {
                    Title = "Razor partials",
                    Body = "Component UI is reused across the home page sections.",
                    ButtonText = "Go to Accordion",
                    ButtonUrl = "#accordion-preview",
                    ButtonSrOnlyText = "section"
                },
                new CardComponentViewModel
                {
                    Title = "View model files",
                    Body = "Separate files keep each component contract isolated and clear.",
                    ButtonText = "Go to Side Navigation",
                    ButtonUrl = "#side-navigation-preview",
                    ButtonSrOnlyText = "section"
                }
            ]
        };
    }

    private static BreadcrumbComponentViewModel BuildBreadcrumbModel()
    {
        return new BreadcrumbComponentViewModel
        {
            Items =
            [
                new BreadcrumbItemComponentViewModel
                {
                    Text = "Home",
                    Url = "#page-top",
                    Title = "Top of page"
                },
                new BreadcrumbItemComponentViewModel
                {
                    Text = "Card Grid",
                    Url = "#card-grid-preview",
                    Title = "Card Grid section"
                },
                new BreadcrumbItemComponentViewModel
                {
                    Text = "Breadcrumb",
                    IsActive = true
                }
            ]
        };
    }

    private static SideNavComponentViewModel BuildSideNavModel()
    {
        return new SideNavComponentViewModel
        {
            AriaLabel = "Component section navigation",
            Items =
            [
                new SideNavItemComponentViewModel
                {
                    Text = "Component overview",
                    Url = "#components",
                    IsLanding = true
                },
                new SideNavItemComponentViewModel
                {
                    Text = "Sections",
                    Children =
                    [
                        new SideNavItemComponentViewModel
                        {
                            Text = "Alert",
                            Url = "#alert-preview"
                        },
                        new SideNavItemComponentViewModel
                        {
                            Text = "Accordion",
                            Url = "#accordion-preview"
                        },
                        new SideNavItemComponentViewModel
                        {
                            Text = "Card Grid",
                            Url = "#card-grid-preview"
                        },
                        new SideNavItemComponentViewModel
                        {
                            Text = "Breadcrumb",
                            Url = "#breadcrumb-preview"
                        },
                        new SideNavItemComponentViewModel
                        {
                            Text = "Side Navigation",
                            Url = "#side-navigation-preview"
                        }
                    ]
                }
            ]
        };
    }
}
