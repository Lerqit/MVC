using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZadaniaDomowe.Data;
using ZadaniaDomowe.Models;

namespace ZadaniaDomowe.Controllers
{
    public class ZadaniaController : Controller
    {
        private readonly ZadanieDane _context;

        public ZadaniaController(ZadanieDane context)
        {
            _context = context;
        }

        // wyswietla liste wszystkich zadan
        public IActionResult Index()
        {
            return View(_context.Zadanie.ToList());
        }

        // formularz dodawania
        public IActionResult Create()
        {
            return View();
        }

        // zapisuje nowe zadanie i wraca do listy
        [HttpPost]
        public IActionResult Create(Zadanie zadanie)
        {
            _context.Zadanie.Add(zadanie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // formularz edycji dla konkretnego zadania
        public IActionResult Edit(int id)
        {
            var zadanie = _context.Zadanie.FirstOrDefault(z => z.Id == id);
            if (zadanie == null)
            {
                return NotFound();
            }
            return View(zadanie);
        }

        // zapisuje zmiany i wraca do listy
        [HttpPost]
        public IActionResult Edit(Zadanie zadanie)
        {
            _context.Zadanie.Update(zadanie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // usuwa zadanie i wraca do listy
        public IActionResult Delete(int id)
        {
            var zadanie = _context.Zadanie.FirstOrDefault(z => z.Id == id);
            if (zadanie != null)
            {
                _context.Zadanie.Remove(zadanie);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}