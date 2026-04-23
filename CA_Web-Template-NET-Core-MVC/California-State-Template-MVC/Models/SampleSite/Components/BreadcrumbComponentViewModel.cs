namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class BreadcrumbComponentViewModel
{
    public string AriaLabel { get; init; } = "Breadcrumb";
    public required IReadOnlyList<BreadcrumbItemComponentViewModel> Items { get; init; }
}
