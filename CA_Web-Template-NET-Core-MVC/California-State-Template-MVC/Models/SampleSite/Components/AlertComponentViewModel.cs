namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class AlertComponentViewModel
{
    public required string EmphasisText { get; init; }
    public required string Message { get; init; }
    public string? LinkText { get; init; }
    public string? LinkUrl { get; init; }
    public string? LinkSrOnlyText { get; init; }
    public string? IconImageUrl { get; init; }
    public string? IconImageAlt { get; init; }
    public string? IconClass { get; init; }
    public bool Dismissible { get; init; } = true;
}
