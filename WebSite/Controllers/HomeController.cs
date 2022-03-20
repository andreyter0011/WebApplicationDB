using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        MonographContext db = new MonographContext();

        public async Task<IActionResult> Index(SortState sortOrder = SortState.PublishAsc)
        {
            IQueryable<Teacher> users = db.Teachers.Include(x => x.Monograph);

            ViewData["PublishSort"] = sortOrder == SortState.PublishAsc ? SortState.PublishDesc : SortState.PublishAsc;

            users = sortOrder switch
            {
                SortState.PublishDesc => users.OrderByDescending(s => s.Name),
                _ => users.OrderBy(s => s.Name),
            };
            return View(await users.AsNoTracking().ToListAsync());
        }
        [HttpGet]
        public ActionResult Create()
        {
            // Формируем список команд для передачи в представление
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            //Добавляем игрока в таблицу
            db.Teachers.Add(teacher);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Monograph()
        {
            // Формируем список команд для передачи в представление
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult Monograph(Monograph monograph)
        {
            //Добавляем игрока в таблицу
            db.Monographs.Add(monograph);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateM()
        {
            // Формируем список команд для передачи в представление
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult CreateM(Monograph monograph)
        {
            //Добавляем игрока в таблицу
            db.Monographs.Add(monograph);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд футболиста
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
            {
                // Создаем список команд для передачи в представление
                SelectList monograph = new SelectList(db.Monographs, "Id", "Name", teacher.MonographId);
                ViewBag.Monograph = monograph;
                return View(teacher);
            }
            return RedirectToAction("Index");
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Edit(Teacher teacher)
        {
            db.Entry(teacher).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Teacher b = db.Teachers.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Teacher b = db.Teachers.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Teachers.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
