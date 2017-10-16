using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using ProyectoProgram.Models;
using System.Text;
using System.Data.Objects.SqlClient;

namespace ProyectoProgram.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        SistemaContableEntities1 bds = new SistemaContableEntities1();
        public ActionResult Inicio()
        {
            return View();
        }

        public JsonResult getMenu()
        {
            try
            {
                var menus = bds.iu_menu.ToList();
                var menusobject = new List<object>();
                foreach (var item in menus)
                {
                    menusobject.Add(new { menu = item.MENU });
                }

                return Json(menusobject, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                throw;
            }
        }

        public JsonResult getRoles()
        {
            var roles = bds.VistaRoles.ToList();
            return Json(roles, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetUsuario(int id)
        {
            var usuario = bds.VistaUsuarios.Find(id);
            return Json(usuario, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getUsuarios()
        {
            var roles = bds.VistaUsuarios.ToList();
            return Json(roles, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOpciones(String menu)
        {
            try
            {
                string usuario = (string)Session["usuario"];
                var opciones = bds.opciones(menu,usuario);
                var opcionesobj = new List<object>();
                foreach (var item in opciones)
                {
                    opcionesobj.Add(new { opcion = item.OPCION});
                }

                return Json(opcionesobj, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                throw;
            }
        }
    }
}