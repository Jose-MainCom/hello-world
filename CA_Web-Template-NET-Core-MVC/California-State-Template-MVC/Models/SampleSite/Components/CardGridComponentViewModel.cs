namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class CardGridComponentViewModel
{
    public required IReadOnlyList<CardComponentViewModel> Cards { get; init; }
}
