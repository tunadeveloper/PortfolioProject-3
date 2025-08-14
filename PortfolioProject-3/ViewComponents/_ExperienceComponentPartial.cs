using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _ExperienceComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }
    }
}
