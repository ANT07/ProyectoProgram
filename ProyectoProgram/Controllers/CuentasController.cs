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
    public class CuentasController : Controller
    {
        private SistemaContableEntities10 db = new SistemaContableEntities10();

        // GET: Cuentas
        public ActionResult Index()
        {
            var tblcuentas = db.tblcuentas.Include(t => t.tblcuentaNivel).Include(t => t.tbltipocuenta).Include(t => t.tblcuenta2);
            return View(tblcuentas.ToList());
        }

        // GET: Cuentas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuenta tblcuenta = db.tblcuentas.Find(id);
            if (tblcuenta == null)
            {
                return HttpNotFound();
            }
            return View(tblcuenta);
        }

        // GET: Cuentas/Create
        public ActionResult Create()
        {
            ViewBag.IDNIVEL = new SelectList(db.tblcuentaNivels, "IDNIVEL", "NUMERONIVEL");
            ViewBag.IDTIPO = new SelectList(db.tbltipocuentas, "IDTIPO", "NOMBRETIPO");
            ViewBag.TBL_IDNIVEL = new SelectList(db.tblcuentas, "IDNIVEL", "CODIGOCUENTA");
            return View();
        }

        // POST: Cuentas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CODIGOCUENTA,IDNIVEL,NOMBRECUENTA,NUMEROCUENTA,TBL_IDNIVEL,TBL_NUMEROCUENTA,IDTIPO,MAYOR,RESUMEN")] tblcuenta tblcuenta)
        {
            if (ModelState.IsValid)
            {
                db.tblcuentas.Add(tblcuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDNIVEL = new SelectList(db.tblcuentaNivels, "IDNIVEL", "NUMERONIVEL", tblcuenta.IDNIVEL);
            ViewBag.IDTIPO = new SelectList(db.tbltipocuentas, "IDTIPO", "NOMBRETIPO", tblcuenta.IDTIPO);
            ViewBag.TBL_IDNIVEL = new SelectList(db.tblcuentas, "IDNIVEL", "CODIGOCUENTA", tblcuenta.TBL_IDNIVEL);
            return View(tblcuenta);
        }

        // GET: Cuentas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuenta tblcuenta = db.tblcuentas.Find(id);
            if (tblcuenta == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDNIVEL = new SelectList(db.tblcuentaNivels, "IDNIVEL", "NUMERONIVEL", tblcuenta.IDNIVEL);
            ViewBag.IDTIPO = new SelectList(db.tbltipocuentas, "IDTIPO", "NOMBRETIPO", tblcuenta.IDTIPO);
            ViewBag.TBL_IDNIVEL = new SelectList(db.tblcuentas, "IDNIVEL", "CODIGOCUENTA", tblcuenta.TBL_IDNIVEL);
            return View(tblcuenta);
        }

        // POST: Cuentas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CODIGOCUENTA,IDNIVEL,NOMBRECUENTA,NUMEROCUENTA,TBL_IDNIVEL,TBL_NUMEROCUENTA,IDTIPO,MAYOR,RESUMEN")] tblcuenta tblcuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblcuenta).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDNIVEL = new SelectList(db.tblcuentaNivels, "IDNIVEL", "NUMERONIVEL", tblcuenta.IDNIVEL);
            ViewBag.IDTIPO = new SelectList(db.tbltipocuentas, "IDTIPO", "NOMBRETIPO", tblcuenta.IDTIPO);
            ViewBag.TBL_IDNIVEL = new SelectList(db.tblcuentas, "IDNIVEL", "CODIGOCUENTA", tblcuenta.TBL_IDNIVEL);
            return View(tblcuenta);
        }

        // GET: Cuentas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblcuenta tblcuenta = db.tblcuentas.Find(id);
            if (tblcuenta == null)
            {
                return HttpNotFound();
            }
            return View(tblcuenta);
        }

        // POST: Cuentas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblcuenta tblcuenta = db.tblcuentas.Find(id);
            db.tblcuentas.Remove(tblcuenta);
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
