using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
