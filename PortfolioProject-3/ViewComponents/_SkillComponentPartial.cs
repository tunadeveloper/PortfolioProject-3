using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _SkillComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
    }
}
