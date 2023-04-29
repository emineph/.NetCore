using kindergardennetcore.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kindergardennetcore.Models;

namespace kindergardennetcore.Controllers
{
    public class OgretmenController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OgretmenController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var listele = _db.Ogretmens.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ogretmen ogretmen)
        {
            _db.Add(ogretmen);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            var yenile = _db.Ogretmens.Find(id);
            return View(yenile);
        }

        [HttpPost]
        public IActionResult Edit(int id, Ogretmen ogretmen)
        {
            _db.Update(ogretmen);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var del = _db.Ogretmens.Find(id);
            return View(del);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Ogretmens.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
