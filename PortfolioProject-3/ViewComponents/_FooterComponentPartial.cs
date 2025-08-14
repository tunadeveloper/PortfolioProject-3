using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _FooterComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }
    }
}
