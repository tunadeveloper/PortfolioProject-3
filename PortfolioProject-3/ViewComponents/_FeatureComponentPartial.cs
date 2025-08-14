using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.Models;

namespace PortfolioProject_3.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        private readonly PortfolioContext _context;

        public _FeatureComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var viewModel = new FeatureAndSocialMediaViewModel
            {
                Features = _context.Features.ToList(),
                SocialMedias = _context.SocialMedias.ToList()
            };
            return View(viewModel);
        }
    }
}
