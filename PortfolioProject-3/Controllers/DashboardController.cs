using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.Controllers
{
    public class DashboardController : Controller
    {
        private readonly PortfolioContext _context;

        public DashboardController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ExperienceCount = _context.Experiences.Count();
            ViewBag.PortfolioCount = _context.Portfolios.Count();
            ViewBag.SkillCount = _context.Skills.Count();
            ViewBag.SocialMediaCount = _context.SocialMedias.Count();
            ViewBag.TestimonialCount = _context.Testimonials.Count();
            ViewBag.MessageCount = _context.Messages.Count();
            ViewBag.UnreadMessageCount = _context.Messages.Count(m => !m.IsRead);
            ViewBag.FeatureCount = _context.Features.Count();

            ViewBag.SkillLabels = _context.Skills.Select(s => s.Title).ToList();
            ViewBag.SkillValues = _context.Skills.Select(s => s.Value).ToList();

            ViewBag.MessageLabels = new[] { "Okundu", "Okunmadı" };
            ViewBag.MessageValues = new[] { _context.Messages.Count(m => m.IsRead), _context.Messages.Count(m => !m.IsRead) };

            return View();
        }
    }
}
