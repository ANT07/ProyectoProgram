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
    public class tblPeriodoesController : Controller
    {
        private SistemaContableEntities10 db = new SistemaContableEntities10();

        // GET: tblPeriodoes
        public ActionResult Index()
        {
            return View(db.tblPeriodoes.ToList());
        }

        // GET: tblPeriodoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPeriodo tblPeriodo = db.tblPeriodoes.Find(id);
            if (tblPeriodo == null)
            {
                return HttpNotFound();
            }
            return View(tblPeriodo);
        }

        // GET: tblPeriodoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblPeriodoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PERIODODESDE,PERIODOHASTA,NOMBREPERIODO,IDPERIODO")] tblPeriodo tblPeriodo)
        {
            if (ModelState.IsValid)
            {
                db.tblPeriodoes.Add(tblPeriodo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblPeriodo);
        }

        // GET: tblPeriodoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPeriodo tblPeriodo = db.tblPeriodoes.Find(id);
            if (tblPeriodo == null)
            {
                return HttpNotFound();
            }
            return View(tblPeriodo);
        }

        // POST: tblPeriodoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PERIODODESDE,PERIODOHASTA,NOMBREPERIODO,IDPERIODO")] tblPeriodo tblPeriodo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPeriodo).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblPeriodo);
        }

        // GET: tblPeriodoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPeriodo tblPeriodo = db.tblPeriodoes.Find(id);
            if (tblPeriodo == null)
            {
                return HttpNotFound();
            }
            return View(tblPeriodo);
        }

        // POST: tblPeriodoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPeriodo tblPeriodo = db.tblPeriodoes.Find(id);
            db.tblPeriodoes.Remove(tblPeriodo);
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
