using kindergardennetcore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kindergardennetcore.Models;

namespace kindergardennetcore.Controllers
{
    public class OkulController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OkulController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var listele = _db.Okuls.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Okul okul)
        {
            _db.Add(okul);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var yenile = _db.Okuls.Find(id);
            return View(yenile);
        }

        [HttpPost]
        public IActionResult Edit(int id, Okul okul)
        {
            _db.Update(okul);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.Okuls.Find(id);
            return View(del);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Okuls.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
