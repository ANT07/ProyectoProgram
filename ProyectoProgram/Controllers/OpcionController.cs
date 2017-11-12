using ProyectoProgram.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProgram.Controllers
{
    public class OpcionController : Controller
    {
        // GET: Opcion

        SistemaContableEntities10 bds = new SistemaContableEntities10();
        public ActionResult Opcion()
        {
            return View();
        }


        public JsonResult GetOPciones()
        {
            var opciones = bds.VistaOpciones;
            return Json(opciones.ToList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOpcion(int opc)
        {
            var opcion = bds.GetOpcion(opc).ToList();
            return Json(opcion.First(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult EliminarOpcion(int opcion)
        {
            var estado = bds.EliminarOpcion(opcion);
            var respuesta = new List<object>();
            if(estado == 1 || estado == 2)
            {
                respuesta.Add(new { correcto = true, mensaje = "Opcion Eliminada" });
            }
            else
            {
                respuesta.Add(new { correcto = false, mensaje = "Error al intentar eliminar Opcion" });
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult AgregarOpcion(int idopcion,string opcion, string vista, string controlador,int menu)
        {
            var respuesta = new List<object>();
            if(idopcion == 0)
            {
                var estado = bds.AgregarOpcion(opcion, vista, controlador, menu);
                if (estado == 2 || estado == 1)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Opcion Agregada" });
                }
                else
                {
                    respuesta.Add(new { correcto = false, mensaje = "No se pudo guardar Opcion" });
                }
            }
            else
            {
                var estado = bds.EditarOpcion(idopcion,opcion, vista, controlador, menu);
                if (estado == 2 || estado == 1)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Opcion Editada" });
                }
                else
                {
                    respuesta.Add(new { correcto = false, mensaje = "No se pudo guardar Opcion" });
                }
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }
    }
}