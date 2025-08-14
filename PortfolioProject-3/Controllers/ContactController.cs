using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class ContactController : Controller
    {
        private readonly PortfolioContext _context;

        public ContactController(PortfolioContext context)
        {
            _context = context;
        }
        public IActionResult Update()
        {
            var contact = _context.Contacts.Find(1);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Update(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("Update");
        }
    }
}
