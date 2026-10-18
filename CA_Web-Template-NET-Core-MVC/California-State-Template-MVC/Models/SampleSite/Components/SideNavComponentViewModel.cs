namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class SideNavComponentViewModel
{
    public string AriaLabel { get; init; } = "list navigation";
    public required IReadOnlyList<SideNavItemComponentViewModel> Items { get; init; }
}
