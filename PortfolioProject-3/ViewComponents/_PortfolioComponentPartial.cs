using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _PortfolioComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}
