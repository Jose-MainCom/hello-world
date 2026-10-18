namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class CardComponentViewModel
{
    public required string Title { get; init; }
    public required string Body { get; init; }
    public string? ButtonText { get; init; }
    public string? ButtonUrl { get; init; }
    public string? ButtonSrOnlyText { get; init; }
}
