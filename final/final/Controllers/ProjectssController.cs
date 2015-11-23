using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using final.Views.Shared;

namespace final.Controllers
{
    public class ProjectssController : Controller
    {
        private ProjectsEntities db = new ProjectsEntities();

        // GET: Projectss
        public ActionResult Index()
        {
            return View(db.projectsses.ToList());
        }

        // GET: Projectss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            projectss projectss = db.projectsses.Find(id);
            if (projectss == null)
            {
                return HttpNotFound();
            }
            return View(projectss);
        }

        // GET: Projectss/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projectss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectID,ProjectName,Description,Repsository,image,collabs")] projectss projectss)
        {
            if (ModelState.IsValid)
            {
                db.projectsses.Add(projectss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projectss);
        }

        // GET: Projectss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            projectss projectss = db.projectsses.Find(id);
            if (projectss == null)
            {
                return HttpNotFound();
            }
            return View(projectss);
        }

        // POST: Projectss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectID,ProjectName,Description,Repsository,image,collabs")] projectss projectss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projectss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projectss);
        }

        // GET: Projectss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            projectss projectss = db.projectsses.Find(id);
            if (projectss == null)
            {
                return HttpNotFound();
            }
            return View(projectss);
        }

        // POST: Projectss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            projectss projectss = db.projectsses.Find(id);
            db.projectsses.Remove(projectss);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
