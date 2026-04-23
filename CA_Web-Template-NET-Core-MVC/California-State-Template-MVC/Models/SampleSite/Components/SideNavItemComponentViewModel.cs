namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class SideNavItemComponentViewModel
{
    public required string Text { get; init; }
    public string? Url { get; init; }
    public bool IsLanding { get; init; }
    public bool IsBack { get; init; }
    public bool IsActive { get; init; }
    public IReadOnlyList<SideNavItemComponentViewModel> Children { get; init; } = [];
}
