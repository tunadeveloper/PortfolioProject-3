using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class SocialMediaController : Controller
    {
        private readonly PortfolioContext _context;

        public SocialMediaController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult SocialMediaList()
        {
            var values = _context.SocialMedias.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult Update(int id)
        {
            var values = _context.SocialMedias.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(SocialMedia socialMedia)
        {
            _context.SocialMedias.Update(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(SocialMedia socialMedia)
        {
            _context.SocialMedias.Add(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}
