using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {

        MonographContext db = new MonographContext();

        public async Task<IActionResult> Index(int? monograph, string name, SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<Teacher> users = db.Teachers.Include(x => x.Monograph);
            ViewData["NameSort"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;

            users = sortOrder switch
            {
                SortState.NameDesc => users.OrderByDescending(s => s.Name),
                _ => users.OrderBy(s => s.Name),
            };
            if (monograph != null && monograph != 0)
            {
                users = users.Where(p => p.MonographId == monograph);
            }
            if (!String.IsNullOrEmpty(name))
            {
                users = users.Where(p => p.Name.Contains(name));
            }
            UserListViewModel viewModel = new UserListViewModel
            {
                Teachers = users.ToList(),
                Name = name
            };
            return View(await users.AsNoTracking().ToListAsync());
        }
        [HttpGet]
        public ActionResult Create()
        {
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            SelectList monographsN = new SelectList(db.Monographs, "Id", "Name");
            SelectList monographsY = new SelectList(db.Monographs, "Id", "Year");
            SelectList monographsC = new SelectList(db.Monographs, "Id", "Count");
            ViewBag.Monograph = monographs;
            ViewBag.MonographN = monographsN;
            ViewBag.MonographY = monographsY;
            ViewBag.MonographC = monographsC;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Teacher teacher)
        {
            db.Teachers.Add(teacher);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
        public ActionResult CreateM()
        {
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult CreateM(Monograph monograph)
        {
            db.Monographs.Add(monograph);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Monograph()
        {
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult Monograph(Monograph monograph)
        {
            db.Monographs.Add(monograph);
            db.SaveChanges();
            // перенаправляем на главную страницу
            return RedirectToAction("Index");
        }

        public ActionResult InputDoc()
        {
            SelectList monographs = new SelectList(db.Monographs, "Id", "Publish");
            ViewBag.Monograph = monographs;
            return View();
        }

        [HttpPost]
        public ActionResult InputDoc(Monograph monograph)
        {
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
            Teacher teacher = db.Teachers.Find(id);
            if (teacher != null)
            {
                SelectList monographsN = new SelectList(db.Monographs, "Id", "Name");
                ViewBag.MonographN = monographsN;
                SelectList monograph = new SelectList(db.Monographs, "Id", "Publish", teacher.MonographId);
                ViewBag.Monograph = monograph;
                return View(teacher);
            }
            return RedirectToAction("Index");
        }
        public ActionResult AllPublish()
        {
            return View(db.Monographs);
        }
        public async Task<IActionResult> AllTeacher(SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<Teacher> teachers = db.Teachers.Include(x => x.Monograph);
            ViewData["NameSort"] = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            teachers = sortOrder switch
            {
                SortState.NameDesc => teachers.OrderByDescending(s => s.Name),
                _ => teachers.OrderBy(s => s.Name),
            };
            return View(await teachers.AsNoTracking().ToListAsync());
        }
        public async Task<IActionResult> TeacherPublish(int? monograph, string name)
        {
            IQueryable<Teacher> teachers = db.Teachers.Include(x => x.Monograph);
            if (monograph != null && monograph != 0)
            {
                teachers = teachers.Where(p => p.MonographId == monograph);
            }
            if (!String.IsNullOrEmpty(name))
            {
                teachers = teachers.Where(p => p.Name.Contains(name));
            }
            UserListViewModel viewModel = new UserListViewModel
            {
                Teachers = teachers.ToList(),
                Name = name
            };
            return View(await teachers.AsNoTracking().ToListAsync());
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
