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

public sealed class CardComponentViewModel
{
    public required string Title { get; init; }
    public required string Body { get; init; }
    public string? ButtonText { get; init; }
    public string? ButtonUrl { get; init; }
    public string? ButtonSrOnlyText { get; init; }
}

public sealed class AccordionComponentViewModel
{
    public required IReadOnlyList<AccordionItemComponentViewModel> Items { get; init; }
}

public sealed class AccordionItemComponentViewModel
{
    public required string Heading { get; init; }
    public required IReadOnlyList<string> Paragraphs { get; init; }
}

public sealed class BreadcrumbComponentViewModel
{
    public string AriaLabel { get; init; } = "Breadcrumb";
    public required IReadOnlyList<BreadcrumbItemComponentViewModel> Items { get; init; }
}

public sealed class BreadcrumbItemComponentViewModel
{
    public required string Text { get; init; }
    public string? Url { get; init; }
    public string? Title { get; init; }
    public bool IsActive { get; init; }
}

public sealed class SideNavComponentViewModel
{
    public string AriaLabel { get; init; } = "list navigation";
    public required IReadOnlyList<SideNavItemComponentViewModel> Items { get; init; }
}

public sealed class SideNavItemComponentViewModel
{
    public required string Text { get; init; }
    public string? Url { get; init; }
    public bool IsLanding { get; init; }
    public bool IsBack { get; init; }
    public bool IsActive { get; init; }
    public IReadOnlyList<SideNavItemComponentViewModel> Children { get; init; } = [];
}
