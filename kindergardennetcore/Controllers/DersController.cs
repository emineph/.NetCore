using kindergardennetcore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kindergardennetcore.Models;

namespace kindergardennetcore.Controllers
{
    public class DersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DersController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var listele = _db.Derses.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ders ders)
        {
            _db.Add(ders);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var yenile = _db.Derses.Find(id);
            return View(yenile);
        }

        [HttpPost]
        public IActionResult Edit(int id, Ders ders)
        {
            _db.Update(ders);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.Derses.Find(id);
            return View(del);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Derses.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
