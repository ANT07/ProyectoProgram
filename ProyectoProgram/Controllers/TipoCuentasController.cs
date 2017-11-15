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
    public class TipoCuentasController : Controller
    {
        private SistemaContableEntities10 db = new SistemaContableEntities10();

        // GET: TipoCuentas
        public ActionResult Index()
        {
            return View(db.tbltipocuentas.ToList());
        }

        // GET: TipoCuentas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipocuenta tbltipocuenta = db.tbltipocuentas.Find(id);
            if (tbltipocuenta == null)
            {
                return HttpNotFound();
            }
            return View(tbltipocuenta);
        }

        // GET: TipoCuentas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoCuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDTIPO,NOMBRETIPO")] tbltipocuenta tbltipocuenta)
        {
            if (ModelState.IsValid)
            {
                db.tbltipocuentas.Add(tbltipocuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbltipocuenta);
        }

        // GET: TipoCuentas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipocuenta tbltipocuenta = db.tbltipocuentas.Find(id);
            if (tbltipocuenta == null)
            {
                return HttpNotFound();
            }
            return View(tbltipocuenta);
        }

        // POST: TipoCuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDTIPO,NOMBRETIPO")] tbltipocuenta tbltipocuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbltipocuenta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbltipocuenta);
        }

        // GET: TipoCuentas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbltipocuenta tbltipocuenta = db.tbltipocuentas.Find(id);
            if (tbltipocuenta == null)
            {
                return HttpNotFound();
            }
            return View(tbltipocuenta);
        }

        // POST: TipoCuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            tbltipocuenta tbltipocuenta = db.tbltipocuentas.Find(id);
            db.tbltipocuentas.Remove(tbltipocuenta);
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
