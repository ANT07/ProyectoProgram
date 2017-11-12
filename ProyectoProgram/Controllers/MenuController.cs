using ProyectoProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgram.Controllers
{
    public class MenuController : Controller
    {
        SistemaContableEntities10 bds = new SistemaContableEntities10();
        // GET: Menu
        public ActionResult Menu()
        {
            return View();
        }

        public JsonResult GetMenus()
        {
            var menus = bds.VistaMenus.ToList();
            return Json(menus, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMenu(int idmenu)
        {
            var menu = bds.VistaMenus.Find(idmenu);
            return Json(menu, JsonRequestBehavior.AllowGet);
        }


        public JsonResult AgregarMenu(int idemenu, string menu,string icono)
        {
            var respuesta = new List<object>();
            var estado = 1;
            try
            {
                if (idemenu == 0)
                {
                    estado = bds.AgregarMenu(menu, icono);
                    if (estado == 1)
                    {
                        respuesta.Add(new { correcto = true, mensaje = "Menu Guardado" });
                    }
                    else
                    {
                        respuesta.Add(new { correcto = false, mensaje = "No se pudo guardar menu" });
                    }
                }
                else
                {
                    estado = bds.EditarMenu(idemenu, menu, icono);

                    if (estado == 1)
                    {
                        respuesta.Add(new { correcto = true, mensaje = "Menu Editado Correctamente" });
                    }
                    else
                    {
                        respuesta.Add(new { correcto = false, mensaje = "No se pudo editar Menu" });
                    }
                }
            }
            catch
            {
                throw;
            }

            {
            }
            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult EliminarMenu(int idemenu)
        {
            var estado = bds.EliminarMenu(idemenu);
            var respuesta = new List<object>();
            if(estado == 1)
            {
                respuesta.Add(new { correcto = true, mensaje = "Menu Eliminado" });
            }
            else
            {
                respuesta.Add(new { correcto = false, mensaje = "Error No se Pudo Eliminar Menu" });
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }
    }
}