using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoProgram.Models;

namespace ProyectoProgram.Controllers
{
    public class tbltipomovimientoesController : Controller
    {
        private SistemaContableEntities10 db = new SistemaContableEntities10();

        // GET: tbltipomovimientoes
        public ActionResult Index()
        {
            return View(db.tbltipomovimientoes.ToList());
        }

        // GET: tbltipomovimientoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipomovimiento tbltipomovimiento = db.tbltipomovimientoes.Find(id);
            if (tbltipomovimiento == null)
            {
                return HttpNotFound();
            }
            return View(tbltipomovimiento);
        }

        // GET: tbltipomovimientoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbltipomovimientoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDMOVIMIENTO,NOMBREMOVIMIENTO")] tbltipomovimiento tbltipomovimiento)
        {
            if (ModelState.IsValid)
            {
                db.tbltipomovimientoes.Add(tbltipomovimiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbltipomovimiento);
        }

        // GET: tbltipomovimientoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipomovimiento tbltipomovimiento = db.tbltipomovimientoes.Find(id);
            if (tbltipomovimiento == null)
            {
                return HttpNotFound();
            }
            return View(tbltipomovimiento);
        }

        // POST: tbltipomovimientoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDMOVIMIENTO,NOMBREMOVIMIENTO")] tbltipomovimiento tbltipomovimiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbltipomovimiento).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbltipomovimiento);
        }

        // GET: tbltipomovimientoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipomovimiento tbltipomovimiento = db.tbltipomovimientoes.Find(id);
            if (tbltipomovimiento == null)
            {
                return HttpNotFound();
            }
            return View(tbltipomovimiento);
        }

        // POST: tbltipomovimientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbltipomovimiento tbltipomovimiento = db.tbltipomovimientoes.Find(id);
            db.tbltipomovimientoes.Remove(tbltipomovimiento);
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
