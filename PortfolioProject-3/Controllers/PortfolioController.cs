using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly PortfolioContext _context;

        public PortfolioController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult PortfolioList()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult Update(int id)
        {
            var values = _context.Portfolios.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
