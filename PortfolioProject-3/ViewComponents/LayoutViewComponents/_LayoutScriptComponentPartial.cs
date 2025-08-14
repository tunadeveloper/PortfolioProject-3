using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject_3.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
