using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
