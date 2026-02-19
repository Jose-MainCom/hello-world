using California_State_Template_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace California_State_Template_MVC.Controllers
{
    public class HomeController : Controller
    {
        private ViewResult SamplePage(string relativePath)
        {
            return View($"~/Views/SampleSite/{relativePath}");
        }

        public IActionResult About()
        {
            return SamplePage("about/index.cshtml");
        }

        public IActionResult About_Careers()
        {
            return SamplePage("about/careers.cshtml");
        }

        public IActionResult About_News()
        {
            return SamplePage("about/news/index.cshtml");
        }

        public IActionResult About_News_Article_Title1()
        {
            return SamplePage("about/news/article-title1.cshtml");
        }

        public IActionResult About_News_Article_Title2()
        {
            return SamplePage("about/news/article-title2.cshtml");
        }

        public IActionResult About_News_Article_Title3()
        {
            return SamplePage("about/news/article-title3.cshtml");
        }

        public IActionResult About_News_Articles()
        {
            return SamplePage("about/news/articles.cshtml");
        }

        public IActionResult About_News_Blog()
        {
            return SamplePage("about/news/blog.cshtml");
        }

        public IActionResult About_News_Blog_Title1()
        {
            return SamplePage("about/news/blog-title1.cshtml");
        }

        public IActionResult About_News_Blog_Title2()
        {
            return SamplePage("about/news/blog-title2.cshtml");
        }

        public IActionResult About_News_Press_Information()
        {
            return SamplePage("about/news/press-information.cshtml");
        }

        public IActionResult About_News_Press_Release_Title1()
        {
            return SamplePage("about/news/press-release-title1.cshtml");
        }

        public IActionResult About_News_Press_Release_Title2()
        {
            return SamplePage("about/news/press-release-title2.cshtml");
        }

        public IActionResult About_News_Press_Releases()
        {
            return SamplePage("about/news/press-releases.cshtml");
        }

        public IActionResult About_News_Subscription_Services()
        {
            return SamplePage("about/news/subscription-services.cshtml");
        }

        public IActionResult About_Our_Organization()
        {
            return SamplePage("about/our-organization.cshtml");
        }

        public IActionResult Accessibility()
        {
            return SamplePage("accessibility.cshtml");
        }

        public IActionResult Blank()
        {
            return SamplePage("blank.cshtml");
        }

        public IActionResult Cagov_Footer()
        {
            return SamplePage("cagov-footer.cshtml");
        }

        public IActionResult Cagov_Header()
        {
            return SamplePage("cagov-header.cshtml");
        }

        public IActionResult Cagov_Header_Full()
        {
            return SamplePage("cagov-header-full.cshtml");
        }

        public IActionResult Cagov_Utility()
        {
            return SamplePage("cagov-utility.cshtml");
        }

        public IActionResult Components_Patterns()
        {
            return SamplePage("components-patterns.cshtml");
        }

        public IActionResult Conditions_Of_Use()
        {
            return SamplePage("conditions-of-use.cshtml");
        }

        public IActionResult Contact()
        {
            return SamplePage("contact.cshtml");
        }

        public IActionResult Content_Directory()
        {
            return SamplePage("content-directory.cshtml");
        }

        public IActionResult Index()
        {
            return SamplePage("index.cshtml");
        }

        public IActionResult Page_404()
        {
            return SamplePage("404.cshtml");
        }

        public IActionResult Privacy_Policy()
        {
            return SamplePage("privacy-policy.cshtml");
        }

        public IActionResult Samples_Accordion()
        {
            return SamplePage("samples/accordion.cshtml");
        }

        public IActionResult Samples_Accordion_List()
        {
            return SamplePage("samples/accordion-list.cshtml");
        }

        public IActionResult Samples_Accordion_Side_Navigation()
        {
            return SamplePage("samples/accordion-side-navigation.cshtml");
        }

        public IActionResult Samples_Alert()
        {
            return SamplePage("samples/alert.cshtml");
        }

        public IActionResult Samples_Alert_Banner()
        {
            return SamplePage("samples/alert-banner.cshtml");
        }

        public IActionResult Samples_Banner()
        {
            return SamplePage("samples/banner.cshtml");
        }

        public IActionResult Samples_Blockquote()
        {
            return SamplePage("samples/blockquote.cshtml");
        }

        public IActionResult Samples_Blockquote_No_Graphic()
        {
            return SamplePage("samples/blockquote-no-graphic.cshtml");
        }

        public IActionResult Samples_Blockquote_Prominent()
        {
            return SamplePage("samples/blockquote-prominent.cshtml");
        }

        public IActionResult Samples_Blockquote_Pull()
        {
            return SamplePage("samples/blockquote-pull.cshtml");
        }

        public IActionResult Samples_Blockquote_With_Image()
        {
            return SamplePage("samples/blockquote-with-image.cshtml");
        }

        public IActionResult Samples_Bootstrap_Side_Navigation_Primary()
        {
            return SamplePage("samples/bootstrap-side-navigation-primary.cshtml");
        }

        public IActionResult Samples_Breadcrumb()
        {
            return SamplePage("samples/breadcrumb.cshtml");
        }

        public IActionResult Samples_Buttons()
        {
            return SamplePage("samples/buttons.cshtml");
        }

        public IActionResult Samples_Buttons_Disabled()
        {
            return SamplePage("samples/buttons-disabled.cshtml");
        }

        public IActionResult Samples_Buttons_Hover()
        {
            return SamplePage("samples/buttons-hover.cshtml");
        }

        public IActionResult Samples_Buttons_Outline()
        {
            return SamplePage("samples/buttons-outline.cshtml");
        }

        public IActionResult Samples_Buttons_Sizes()
        {
            return SamplePage("samples/buttons-sizes.cshtml");
        }

        public IActionResult Samples_Card_Default()
        {
            return SamplePage("samples/card-default.cshtml");
        }

        public IActionResult Samples_Card_Grid_Basic()
        {
            return SamplePage("samples/card-grid-basic.cshtml");
        }

        public IActionResult Samples_Card_Grid_Icons()
        {
            return SamplePage("samples/card-grid-icons.cshtml");
        }

        public IActionResult Samples_Card_Grid_Images()
        {
            return SamplePage("samples/card-grid-images.cshtml");
        }

        public IActionResult Samples_Card_Icon()
        {
            return SamplePage("samples/card-icon.cshtml");
        }

        public IActionResult Samples_Card_Image()
        {
            return SamplePage("samples/card-image.cshtml");
        }

        public IActionResult Samples_Card_Legacy()
        {
            return SamplePage("samples/card-legacy.cshtml");
        }

        public IActionResult Samples_Countdown_Timer()
        {
            return SamplePage("samples/countdown-timer.cshtml");
        }

        public IActionResult Samples_Executive_Profile()
        {
            return SamplePage("samples/executive-profile.cshtml");
        }

        public IActionResult Samples_Executive_Profile_Dark()
        {
            return SamplePage("samples/executive-profile-dark.cshtml");
        }

        public IActionResult Samples_Executive_Profile_Transparent()
        {
            return SamplePage("samples/executive-profile-transparent.cshtml");
        }

        public IActionResult Samples_External_Links()
        {
            return SamplePage("samples/external-links.cshtml");
        }

        public IActionResult Samples_Feature_Card()
        {
            return SamplePage("samples/feature-card.cshtml");
        }

        public IActionResult Samples_Featured_Search()
        {
            return SamplePage("samples/featured-search.cshtml");
        }

        public IActionResult Samples_Form_Checkbox()
        {
            return SamplePage("samples/form-checkbox.cshtml");
        }

        public IActionResult Samples_Form_Dropdown()
        {
            return SamplePage("samples/form-dropdown.cshtml");
        }

        public IActionResult Samples_Form_File_Input()
        {
            return SamplePage("samples/form-file-input.cshtml");
        }

        public IActionResult Samples_Form_Label()
        {
            return SamplePage("samples/form-label.cshtml");
        }

        public IActionResult Samples_Form_Radio()
        {
            return SamplePage("samples/form-radio.cshtml");
        }

        public IActionResult Samples_Form_Textarea()
        {
            return SamplePage("samples/form-textarea.cshtml");
        }

        public IActionResult Samples_Form_Textarea_Required()
        {
            return SamplePage("samples/form-textarea-required.cshtml");
        }

        public IActionResult Samples_Form_Textfield()
        {
            return SamplePage("samples/form-textfield.cshtml");
        }

        public IActionResult Samples_Form_Textfield_Required()
        {
            return SamplePage("samples/form-textfield-required.cshtml");
        }

        public IActionResult Samples_Gradient_Linear()
        {
            return SamplePage("samples/gradient-linear.cshtml");
        }

        public IActionResult Samples_Gradient_Radial()
        {
            return SamplePage("samples/gradient-radial.cshtml");
        }

        public IActionResult Samples_Header_Primary_Banner()
        {
            return SamplePage("samples/header-primary-banner.cshtml");
        }

        public IActionResult Samples_Horizontal_Separator()
        {
            return SamplePage("samples/horizontal-separator.cshtml");
        }

        public IActionResult Samples_Link_Grid()
        {
            return SamplePage("samples/link-grid.cshtml");
        }

        public IActionResult Samples_List_Ordered()
        {
            return SamplePage("samples/list-ordered.cshtml");
        }

        public IActionResult Samples_List_Unordered()
        {
            return SamplePage("samples/list-unordered.cshtml");
        }

        public IActionResult Samples_Megamenu()
        {
            return SamplePage("samples/megamenu.cshtml");
        }

        public IActionResult Samples_Modal()
        {
            return SamplePage("samples/modal.cshtml");
        }

        public IActionResult Samples_Nav_Side_Accordion()
        {
            return SamplePage("samples/nav-side-accordion.cshtml");
        }

        public IActionResult Samples_Navigation_With_Icons()
        {
            return SamplePage("samples/navigation-with-icons.cshtml");
        }

        public IActionResult Samples_News_Article()
        {
            return SamplePage("samples/news-article.cshtml");
        }

        public IActionResult Samples_News_Block()
        {
            return SamplePage("samples/news-block.cshtml");
        }

        public IActionResult Samples_News_Cards()
        {
            return SamplePage("samples/news-cards.cshtml");
        }

        public IActionResult Samples_News_Featured_Banner()
        {
            return SamplePage("samples/news-featured-banner.cshtml");
        }

        public IActionResult Samples_News_List()
        {
            return SamplePage("samples/news-list.cshtml");
        }

        public IActionResult Samples_News_List_Extended()
        {
            return SamplePage("samples/news-list-extended.cshtml");
        }

        public IActionResult Samples_News_List_Featured()
        {
            return SamplePage("samples/news-list-featured.cshtml");
        }

        public IActionResult Samples_Number_Counter()
        {
            return SamplePage("samples/number-counter.cshtml");
        }

        public IActionResult Samples_Page_Navigation()
        {
            return SamplePage("samples/page-navigation.cshtml");
        }

        public IActionResult Samples_Page_Navigation_More()
        {
            return SamplePage("samples/page-navigation-more.cshtml");
        }

        public IActionResult Samples_Pagination()
        {
            return SamplePage("samples/pagination.cshtml");
        }

        public IActionResult Samples_Progress_Bar()
        {
            return SamplePage("samples/progress-bar.cshtml");
        }

        public IActionResult Samples_Progress_Block()
        {
            return SamplePage("samples/progress-block.cshtml");
        }

        public IActionResult Samples_Progress_Block_Bold()
        {
            return SamplePage("samples/progress-block-bold.cshtml");
        }

        public IActionResult Samples_Section_Primary()
        {
            return SamplePage("samples/section-primary.cshtml");
        }

        public IActionResult Samples_Section_Standout()
        {
            return SamplePage("samples/section-standout.cshtml");
        }

        public IActionResult Samples_Side_Navigation()
        {
            return SamplePage("samples/side-navigation.cshtml");
        }

        public IActionResult Samples_Side_Navigation_Level1()
        {
            return SamplePage("samples/side-navigation-level1.cshtml");
        }

        public IActionResult Samples_Side_Navigation_Level2()
        {
            return SamplePage("samples/side-navigation-level2.cshtml");
        }

        public IActionResult Samples_Side_Navigation_Level3()
        {
            return SamplePage("samples/side-navigation-level3.cshtml");
        }

        public IActionResult Samples_Site_Footer()
        {
            return SamplePage("samples/site-footer.cshtml");
        }

        public IActionResult Samples_Site_Header_Sample_Site()
        {
            return SamplePage("samples/site-header-sample-site.cshtml");
        }

        public IActionResult Samples_Site_Header_Sample_Site_News()
        {
            return SamplePage("samples/site-header-sample-site-news.cshtml");
        }

        public IActionResult Samples_Social_Media_Icons()
        {
            return SamplePage("samples/social-media-icons.cshtml");
        }

        public IActionResult Samples_Step_List()
        {
            return SamplePage("samples/step-list.cshtml");
        }

        public IActionResult Samples_Table()
        {
            return SamplePage("samples/table.cshtml");
        }

        public IActionResult Samples_Table_Default()
        {
            return SamplePage("samples/table-default.cshtml");
        }

        public IActionResult Samples_Table_Striped()
        {
            return SamplePage("samples/table-striped.cshtml");
        }

        public IActionResult Samples_Tabs()
        {
            return SamplePage("samples/tabs.cshtml");
        }

        public IActionResult Samples_Timeline()
        {
            return SamplePage("samples/timeline.cshtml");
        }

        public IActionResult Serp()
        {
            return SamplePage("serp.cshtml");
        }

        public IActionResult Sitemap()
        {
            return SamplePage("sitemap.cshtml");
        }

        public IActionResult Template_Header_Full()
        {
            return SamplePage("template-header-full.cshtml");
        }

        public IActionResult Top_Task_1()
        {
            return SamplePage("top-task-1/index.cshtml");
        }

        public IActionResult Top_Task_1_Content_Page_1()
        {
            return SamplePage("top-task-1/content-page-1.cshtml");
        }

        public IActionResult Top_Task_1_Content_Page_2()
        {
            return SamplePage("top-task-1/content-page-2.cshtml");
        }

        public IActionResult Top_Task_1_Content_Page_3()
        {
            return SamplePage("top-task-1/content-page-3.cshtml");
        }

        public IActionResult Top_Task_1_Content_Page_4()
        {
            return SamplePage("top-task-1/content-page-4.cshtml");
        }

        public IActionResult Top_Task_2()
        {
            return SamplePage("top-task-2/index.cshtml");
        }

        public IActionResult Top_Task_2_Content_Page_1()
        {
            return SamplePage("top-task-2/content-page-1.cshtml");
        }

        public IActionResult Top_Task_2_Content_Page_2()
        {
            return SamplePage("top-task-2/content-page-2.cshtml");
        }

        public IActionResult Website_Accessibility_Certification()
        {
            return SamplePage("website-accessibility-certification.cshtml");
        }

        public IActionResult Newsroom()
        {
            return RedirectToAction(nameof(About_News));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
