namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class BreadcrumbItemComponentViewModel
{
    public required string Text { get; init; }
    public string? Url { get; init; }
    public string? Title { get; init; }
    public bool IsActive { get; init; }
}
