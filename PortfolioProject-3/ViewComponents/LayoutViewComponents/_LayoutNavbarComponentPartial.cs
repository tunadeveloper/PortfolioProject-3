using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
