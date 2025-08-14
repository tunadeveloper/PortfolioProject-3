using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
