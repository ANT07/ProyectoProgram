using ProyectoProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgram.Controllers
{
    public class Rol_OpcionController : Controller
    {
        // GET: Rol_Opcion
        SistemaContableEntities10 bds = new SistemaContableEntities10();
        public ActionResult Rol_Opcion()
        {
            return View();
        }


        public JsonResult GetPrivilegios()
        {
            var Privilegios = bds.GetPrivilegios.ToList();
            return Json(Privilegios, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPrivilegio(int opc, int rol)
        {
            var Privilegios = bds.GetPrivilegios.Single(u => u.ID_OPCION == opc & u.ID_ROL == rol);
            return Json(Privilegios, JsonRequestBehavior.AllowGet);
        }

        public JsonResult AgregarPrivilegio(int agregarFuncion,int opc, int rol, int acceso/*, int agregar, int editar, int eliminar*/)
        {
            int prueba = 0;
            List<object> respuesta = new List<object>();
            if(agregarFuncion == 1)
            {
                prueba = bds.AgregarPrivilegio(opc, rol, acceso/*, agregar, editar, eliminar*/);
                if(prueba > 0)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Privilegio Guardado" });
                }
                else
                {
                    respuesta.Add(new { correcto = false, mensaje = "Privilegio No Guardado" });
                }

            }
            else
            {
                prueba = bds.EditarPrivilegio(opc, rol, acceso /*,agregar, editar, eliminar*/);
                if (prueba > 0)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Privilegio Editado" });
                }
                else
                {
                    respuesta.Add(new { correcto = false, mensaje = "Privilegio No Editado" });
                }
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Eliminar(int opcion, int rol)
        {
            var prueba = bds.EliminarPrivilegio(opcion, rol);
            List<object> respuesta = new List<object>();
            if (prueba == 1)
            {
                respuesta.Add(new { correcto = true, mensaje = "Privilegio Eliminado" });
            }
            else
            {
                respuesta.Add(new { correcto = false, mensaje = "Privilegio No Eliminado" });
            }
            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }
    }
}