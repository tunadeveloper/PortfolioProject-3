using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly PortfolioContext _context;

        public ExperienceController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult ExperienceList()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _context.Experiences.Find(id);
            _context.Experiences.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Update(int id)
        {
            var values = _context.Experiences.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult Create() => View();
        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
