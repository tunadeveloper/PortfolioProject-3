using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
