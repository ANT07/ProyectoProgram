using ProyectoProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgram.Controllers
{
    public class RolController : Controller
    {
        // GET: Rol
        SistemaContableEntities10 bds = new SistemaContableEntities10();

        public ActionResult Rol()
        {
            return View();
        }


        public JsonResult GetRoles()
        {
            return Json(bds.VistaRoles.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRol(int idrol)
        {
            var rol = bds.VistaRoles.Find(idrol);
            return Json(rol, JsonRequestBehavior.AllowGet);
        }

        public JsonResult EliminarRol(int idrol)
        {
            var respuesta = new List<object>();
            var estado = bds.EliminarRol(idrol);

            if(estado == 1)
            {
                respuesta.Add(new { correcto = true , mensaje = "Rol Eliminado Correctamente"});
            }
            else
            {
                respuesta.Add(new { correcto = true, mensaje = "Error al intentar Eliminar Rol de Usuario" });
            }
            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AgregarRol(int idrol,string rol)
        {
            var respuesta = new List<object>();

            if(idrol == 0)
            {
                var estado = bds.AgregarRol(rol);
                if (estado == 1)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Rol Guardado" });
                }
                else
                {
                    respuesta.Add(new { correcto = true, mensaje = "Error al intentar Guardar Rol" });
                }
            }
            else
            {
                var estado = bds.EditarRol(idrol,rol);  
                if (estado == 1)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Rol Guardado" });
                }
                else
                {
                    respuesta.Add(new { correcto = true, mensaje = "Error al intentar Guardar Rol" });
                }
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }
    }
}