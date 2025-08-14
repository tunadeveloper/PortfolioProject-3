using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _AboutComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = _context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubdescription = _context.Abouts.Select(x=>x.Subdescription).FirstOrDefault();
            ViewBag.aboutDetail = _context.Abouts.Select(x=>x.Detail).FirstOrDefault();
            return View();
        }
    }
}
