using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoProgram.Models;

namespace ProyectoProgram.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private SistemaContableEntities1 bds = new SistemaContableEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Ingresar(String usuario,String contrasena)
        {
            bool correcto = false;
            string mensaje = "";
            List<Object> respuesta = new List<object>();

            var usuarioEncontrado = from u in bds.usuarios where u.NOMBRE == usuario where u.CLAVE == contrasena where u.ESTADO == 1 select u;

            if(usuario.Equals("") || contrasena.Equals(""))
            {
                correcto = false;
                mensaje = "Completar Informacion";
            }
            else if( usuarioEncontrado.Count() > 0)
            {
                correcto = true;
                mensaje = "Acceso Correcto";
                this.Session["usuario"] = usuario;
            }
            else
            {
                correcto = false;
                mensaje = "Usuario no Contraseña Incorrecto";
            }

            respuesta.Add(new {correcto,mensaje});

            return Json(respuesta.First(),JsonRequestBehavior.AllowGet);
        }
    }
}