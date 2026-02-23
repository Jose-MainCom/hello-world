namespace California_State_Template_MVC.Models.SampleSite.Components;

public sealed class AccordionItemComponentViewModel
{
    public required string Heading { get; init; }
    public required IReadOnlyList<string> Paragraphs { get; init; }
}
