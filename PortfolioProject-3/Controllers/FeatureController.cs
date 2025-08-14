using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class FeatureController : Controller
    {
        private readonly PortfolioContext _context;

        public FeatureController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Update()
        {
            var feature = _context.Features.Find(1);
            return View(feature);
        }

        [HttpPost]
        public IActionResult Update(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("Update");
        }
    }
}
