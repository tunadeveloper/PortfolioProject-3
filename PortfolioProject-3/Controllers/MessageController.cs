using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;
using PortfolioProject_3.DataAccess.Entities;

namespace PortfolioProject_3.Controllers
{
    public class MessageController : Controller
    {
        private readonly PortfolioContext _context;

        public MessageController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult MessageList()
        {
            var messages = _context.Messages
                            .OrderByDescending(m => m.Id)
                            .ToList();
            return View(messages);
        }

        public IActionResult Delete(int id)
        {
            var message = _context.Messages.Find(id);
                _context.Messages.Remove(message);
                _context.SaveChanges();
            return RedirectToAction("MessageList");
        }

        public IActionResult Detail(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null && !message.IsRead)
            {
                message.IsRead = true; 
                _context.Messages.Update(message);
                _context.SaveChanges();
            }
            return View(message);
        }

        public IActionResult MarkAsRead(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null && !message.IsRead)
            {
                message.IsRead = true;
                _context.Messages.Update(message);
                _context.SaveChanges();
            }
            return RedirectToAction("Detail", new { id = id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}
