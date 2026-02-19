namespace California_State_Template_MVC.Models.SampleSite;

public sealed class LinkViewModel
{
    public required string Text { get; init; }
    public required string Url { get; init; }
    public bool IsActive { get; init; }
}

public sealed class NewsItemViewModel
{
    public required string Title { get; init; }
    public required string Url { get; init; }
    public required string Meta { get; init; }
    public string? Summary { get; init; }
    public string? ImageUrl { get; init; }
    public string? ImageAlt { get; init; }
}

public sealed class MarketingCardViewModel
{
    public required string Title { get; init; }
    public required string Url { get; init; }
    public required string Description { get; init; }
}

public sealed class ExecutiveProfileViewModel
{
    public required string OfficialTitle { get; init; }
    public required string Name { get; init; }
    public required string Agency { get; init; }
    public required string BioUrl { get; init; }
    public required string BioLinkText { get; init; }
    public required string ImageUrl { get; init; }
    public required string ImageAlt { get; init; }
}

public sealed class HomePageViewModel
{
    public required string HeroTitle { get; init; }
    public required string HeroIntro { get; init; }
    public required string HeroSupportingText { get; init; }
    public required string HeroButtonText { get; init; }
    public required string HeroButtonUrl { get; init; }
    public required string HeroImageUrl { get; init; }
    public required string HeroImageAriaLabel { get; init; }
    public required IReadOnlyList<LinkViewModel> TopTasks { get; init; }
    public required IReadOnlyList<MarketingCardViewModel> MarketingCards { get; init; }
    public required IReadOnlyList<NewsItemViewModel> FeaturedNews { get; init; }
    public required string NewsViewAllUrl { get; init; }
    public required string SideCardHeading { get; init; }
    public required IReadOnlyList<string> SideCardParagraphs { get; init; }
    public required IReadOnlyList<ExecutiveProfileViewModel> ExecutiveProfiles { get; init; }
}

public sealed class AboutPageViewModel
{
    public required string Heading { get; init; }
    public required string IntroText { get; init; }
    public required IReadOnlyList<LinkViewModel> SideNavigation { get; init; }
    public required string VisionText { get; init; }
    public required string GoalsText { get; init; }
    public required IReadOnlyList<string> Goals { get; init; }
    public required IReadOnlyList<LinkViewModel> LearnMoreLinks { get; init; }
}

public sealed class NewsroomPromoCardViewModel
{
    public required string Title { get; init; }
    public required string Url { get; init; }
    public string? Meta { get; init; }
    public required string Description { get; init; }
}

public sealed class NewsroomPageViewModel
{
    public required IReadOnlyList<LinkViewModel> SideNavigation { get; init; }
    public required IReadOnlyList<NewsItemViewModel> FeaturedItems { get; init; }
    public required IReadOnlyList<NewsroomPromoCardViewModel> PromoCards { get; init; }
    public required IReadOnlyList<NewsItemViewModel> LatestNews { get; init; }
    public required string ViewAllUrl { get; init; }
}
