using Microsoft.AspNetCore.Mvc;
using PortfolioProject_3.DataAccess.Context;

namespace PortfolioProject_3.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
   private readonly PortfolioContext _context;

        public _ContactComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.title = _context.Contacts.Select(x => x.Title).FirstOrDefault();
            ViewBag.description = _context.Contacts.Select(x=>x.Description).FirstOrDefault();
            ViewBag.phone1 = _context.Contacts.Select(x=>x.Phone1).FirstOrDefault();
            ViewBag.phone2 = _context.Contacts.Select(x=>x.Phone2).FirstOrDefault();
            ViewBag.email1 = _context.Contacts.Select(x=>x.Email1).FirstOrDefault();
            ViewBag.email2 = _context.Contacts.Select(x=>x.Email2).FirstOrDefault();
            ViewBag.address = _context.Contacts.Select(x=>x.Address).FirstOrDefault();
            return View();
        }
    }
}
