using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly PortfolioContext _context;

        public TestimonialController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult TestimonialList()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult Update(int id)
        {
            var values = _context.Testimonials.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
