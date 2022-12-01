using Microsoft.AspNetCore.Mvc;

namespace AppInsightsTraceWarning.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return RedirectPermanent("/api/version");
        }
    }
}
