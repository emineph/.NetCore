using kindergardennetcore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kindergardennetcore.Models;

namespace kindergardennetcore.Controllers
{
    public class OgrenciController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OgrenciController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var listele = _db.Ogrencis.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ogrenci ogrenci)
        {
            _db.Add(ogrenci);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var yenile = _db.Ogrencis.Find(id);
            return View(yenile);
        }

        [HttpPost]
        public IActionResult Edit(int id, Ogrenci ogrenci)
        {
            _db.Update(ogrenci);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.Ogrencis.Find(id);
            return View(del);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Ogrencis.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
