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
    public class CuentaNivelesController : Controller
    {
        private SistemaContableEntities10 db = new SistemaContableEntities10();

        // GET: CuentaNiveles
        public ActionResult Index()
        {
            return View(db.tblcuentaNivels.ToList());
        }

        // GET: CuentaNiveles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuentaNivel tblcuentaNivel = db.tblcuentaNivels.Find(id);
            if (tblcuentaNivel == null)
            {
                return HttpNotFound();
            }
            return View(tblcuentaNivel);
        }

        // GET: CuentaNiveles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CuentaNiveles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDNIVEL,NUMERONIVEL")] tblcuentaNivel tblcuentaNivel)
        {
            if (ModelState.IsValid)
            {
                db.tblcuentaNivels.Add(tblcuentaNivel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblcuentaNivel);
        }

        // GET: CuentaNiveles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuentaNivel tblcuentaNivel = db.tblcuentaNivels.Find(id);
            if (tblcuentaNivel == null)
            {
                return HttpNotFound();
            }
            return View(tblcuentaNivel);
        }

        // POST: CuentaNiveles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDNIVEL,NUMERONIVEL")] tblcuentaNivel tblcuentaNivel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblcuentaNivel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblcuentaNivel);
        }

        // GET: CuentaNiveles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuentaNivel tblcuentaNivel = db.tblcuentaNivels.Find(id);
            if (tblcuentaNivel == null)
            {
                return HttpNotFound();
            }
            return View(tblcuentaNivel);
        }

        // POST: CuentaNiveles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblcuentaNivel tblcuentaNivel = db.tblcuentaNivels.Find(id);
            db.tblcuentaNivels.Remove(tblcuentaNivel);
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
