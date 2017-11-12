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
        SistemaContableEntities10 bds = new SistemaContableEntities10();
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
                    menusobject.Add(new { menu = item.MENU , icono = item.ICONO});
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

        public JsonResult GetUsuario(int id, int rol)
        {
            var usuario = bds.VistaUsuarios.Find(id,rol);
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
                    opcionesobj.Add(new { opcion = item.OPCION,agregar = item.AGREGAR , acceder = item.ACCESO,editar = item.AGREGAR , eliminar = item.ELIMINAR, vista = item.VISTA , controlador = item.CONTROLADOR});
                }

                return Json(opcionesobj, JsonRequestBehavior.AllowGet);
            }
            catch
            {
                throw;
            }
        }

        public JsonResult AgregarUsuario(int ide ,string usuario, string nombrecompleto,int idrol , int estadoUsuario,string contrasena)
        {
            var respuesta = new List<object>();
            var estado = 1;
            try
            {
                if(ide == 0)
                {
                    estado = bds.AgregarUsuario(usuario, contrasena, idrol, nombrecompleto, estadoUsuario);
                    if (estado == 1)
                    {
                        respuesta.Add(new { correcto = true, mensaje = "Usuario Guardado" });
                    }
                    else
                    {
                        respuesta.Add(new { correcto = false, mensaje = "No se pudo guardar usuario" });
                    }
                }
                else
                {
                    estado = bds.EditarUsuario( usuario, contrasena, idrol, nombrecompleto, estadoUsuario, ide);

                    if (estado == 1)
                    {
                        respuesta.Add(new { correcto = true, mensaje = "Usuario Editado Correctamente" });
                    }
                    else
                    {
                        respuesta.Add(new { correcto = false, mensaje = "No se pudo editar Usuario" });
                    }
                }
            }
            catch
            {
                throw;
            }

            {
            }
            return Json(respuesta.First(),JsonRequestBehavior.AllowGet);
        }

        public JsonResult Almacenar(string vista, string controlador)
        {
            Session["vista"] = vista;
            Session["controlador"] = controlador;

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        public JsonResult EliminarUsuario(int id)
        {
            var respuesta = new List<object>();
            try
            {
                int estado = bds.EliminarUsuario(id);
                if (estado == 1)
                {
                    respuesta.Add(new { correcto = true, mensaje = "Usuario Eliminado" });
                }
                else
                {
                    respuesta.Add(new { correcto = false, mensaje = "Error Al Intentar Eliminar Usuario" });
                }
            }
            catch
            {
                throw;
            }

            return Json(respuesta.First(), JsonRequestBehavior.AllowGet);
        }
    }
}