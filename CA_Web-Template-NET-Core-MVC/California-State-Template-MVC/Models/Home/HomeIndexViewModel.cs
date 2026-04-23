using California_State_Template_MVC.Models.SampleSite.Components;

namespace California_State_Template_MVC.Models.Home;

public sealed class HomeIndexViewModel
{
    public required IReadOnlyList<ComponentLinkViewModel> ComponentLinks { get; init; }
    public required AlertComponentViewModel Alert { get; init; }
    public required AccordionComponentViewModel Accordion { get; init; }
    public required CardGridComponentViewModel CardGrid { get; init; }
    public required BreadcrumbComponentViewModel Breadcrumb { get; init; }
    public required SideNavComponentViewModel SideNavigation { get; init; }
}
