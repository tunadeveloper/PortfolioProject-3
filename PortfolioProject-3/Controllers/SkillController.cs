using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class SkillController : Controller
    {
        private readonly PortfolioContext _context;

        public SkillController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult SkillList()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _context.Skills.Find(id);
            _context.Skills.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult Update(int id)
        {
            var values = _context.Skills.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }}
