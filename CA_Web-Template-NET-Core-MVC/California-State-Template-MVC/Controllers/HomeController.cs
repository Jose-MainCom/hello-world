using California_State_Template_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace California_State_Template_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string _viewRoot;

        public HomeController(IWebHostEnvironment hostEnvironment)
        {
            _viewRoot = Path.Combine(hostEnvironment.ContentRootPath, "Views", "SampleSite");
        }

        public IActionResult Index()
        {
            return View("~/Views/SampleSite/index.cshtml");
        }

        public IActionResult Page(string path)
        {
            var viewPath = ResolveViewPath(path);
            if (viewPath is null)
            {
                Response.StatusCode = StatusCodes.Status404NotFound;
                return View("~/Views/SampleSite/404.cshtml");
            }

            return View($"~/Views/SampleSite/{viewPath}.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string? ResolveViewPath(string? rawPath)
        {
            var normalized = NormalizePath(rawPath);
            if (normalized is null)
            {
                return null;
            }

            foreach (var candidate in BuildCandidates(normalized))
            {
                var physicalPath = Path.Combine(
                    _viewRoot,
                    candidate.Replace('/', Path.DirectorySeparatorChar) + ".cshtml");
                if (System.IO.File.Exists(physicalPath))
                {
                    return candidate;
                }
            }

            return null;
        }

        private static string? NormalizePath(string? rawPath)
        {
            if (string.IsNullOrWhiteSpace(rawPath))
            {
                return "index";
            }

            var path = Uri.UnescapeDataString(rawPath).Replace('\\', '/').Trim('/');
            if (string.IsNullOrWhiteSpace(path))
            {
                return "index";
            }

            if (path.Contains("..", StringComparison.Ordinal))
            {
                return null;
            }

            return path;
        }

        private static IEnumerable<string> BuildCandidates(string normalizedPath)
        {
            var results = new List<string>();
            var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            void Add(string? candidate)
            {
                if (string.IsNullOrWhiteSpace(candidate))
                {
                    return;
                }

                var value = candidate.Trim('/');
                if (string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                if (seen.Add(value))
                {
                    results.Add(value);
                }
            }

            Add(normalizedPath);

            var noHtml = normalizedPath.EndsWith(".html", StringComparison.OrdinalIgnoreCase)
                ? normalizedPath[..^5]
                : normalizedPath;

            Add(noHtml);
            Add($"{noHtml}/index");

            if (noHtml.EndsWith("/index", StringComparison.OrdinalIgnoreCase))
            {
                Add(noHtml[..^6]);
            }

            return results;
        }
    }
}
