﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoProgram.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SistemaContableEntities10 : DbContext
    {
        public SistemaContableEntities10()
            : base("name=SistemaContableEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<iu_menu> iu_menu { get; set; }
        public virtual DbSet<iu_opcion> iu_opcion { get; set; }
        public virtual DbSet<iu_rol> iu_rol { get; set; }
        public virtual DbSet<iu_rol_menu> iu_rol_menu { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblcuenta> tblcuentas { get; set; }
        public virtual DbSet<tblcuentaNivel> tblcuentaNivels { get; set; }
        public virtual DbSet<tbldetallepartida> tbldetallepartidas { get; set; }
        public virtual DbSet<tblmaestropartida> tblmaestropartidas { get; set; }
        public virtual DbSet<tbltipocuenta> tbltipocuentas { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<GetPrivilegio> GetPrivilegios { get; set; }
        public virtual DbSet<usuario1> usuarios1 { get; set; }
        public virtual DbSet<VistaMenu> VistaMenus { get; set; }
        public virtual DbSet<VistaOpcione> VistaOpciones { get; set; }
        public virtual DbSet<VistaRole> VistaRoles { get; set; }
        public virtual DbSet<VistaUsuario> VistaUsuarios { get; set; }
    
        public virtual int AgregarMenu(string menu, string icono)
        {
            var menuParameter = menu != null ?
                new ObjectParameter("menu", menu) :
                new ObjectParameter("menu", typeof(string));
    
            var iconoParameter = icono != null ?
                new ObjectParameter("icono", icono) :
                new ObjectParameter("icono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarMenu", menuParameter, iconoParameter);
        }
    
        public virtual int AgregarOpcion(string opcion, string vista, string controlador, Nullable<int> id_menu)
        {
            var opcionParameter = opcion != null ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(string));
    
            var vistaParameter = vista != null ?
                new ObjectParameter("vista", vista) :
                new ObjectParameter("vista", typeof(string));
    
            var controladorParameter = controlador != null ?
                new ObjectParameter("controlador", controlador) :
                new ObjectParameter("controlador", typeof(string));
    
            var id_menuParameter = id_menu.HasValue ?
                new ObjectParameter("id_menu", id_menu) :
                new ObjectParameter("id_menu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarOpcion", opcionParameter, vistaParameter, controladorParameter, id_menuParameter);
        }
    
        public virtual int AgregarPrivilegio(Nullable<int> opcion, Nullable<int> rol, Nullable<int> acceder)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            var accederParameter = acceder.HasValue ?
                new ObjectParameter("acceder", acceder) :
                new ObjectParameter("acceder", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarPrivilegio", opcionParameter, rolParameter, accederParameter);
        }
    
        public virtual int AgregarRol(string rol)
        {
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarRol", rolParameter);
        }
    
        public virtual int AgregarUsuario(string usuario, string clave, Nullable<int> id_rol, string nombre_completo, Nullable<int> estado)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var id_rolParameter = id_rol.HasValue ?
                new ObjectParameter("id_rol", id_rol) :
                new ObjectParameter("id_rol", typeof(int));
    
            var nombre_completoParameter = nombre_completo != null ?
                new ObjectParameter("nombre_completo", nombre_completo) :
                new ObjectParameter("nombre_completo", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AgregarUsuario", usuarioParameter, claveParameter, id_rolParameter, nombre_completoParameter, estadoParameter);
        }
    
        public virtual int EditarMenu(Nullable<int> idmenu, string menu, string icono)
        {
            var idmenuParameter = idmenu.HasValue ?
                new ObjectParameter("idmenu", idmenu) :
                new ObjectParameter("idmenu", typeof(int));
    
            var menuParameter = menu != null ?
                new ObjectParameter("menu", menu) :
                new ObjectParameter("menu", typeof(string));
    
            var iconoParameter = icono != null ?
                new ObjectParameter("icono", icono) :
                new ObjectParameter("icono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarMenu", idmenuParameter, menuParameter, iconoParameter);
        }
    
        public virtual int EditarOpcion(Nullable<int> idopcion, string opcion, string vista, string controlador, Nullable<int> id_menu)
        {
            var idopcionParameter = idopcion.HasValue ?
                new ObjectParameter("idopcion", idopcion) :
                new ObjectParameter("idopcion", typeof(int));
    
            var opcionParameter = opcion != null ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(string));
    
            var vistaParameter = vista != null ?
                new ObjectParameter("vista", vista) :
                new ObjectParameter("vista", typeof(string));
    
            var controladorParameter = controlador != null ?
                new ObjectParameter("controlador", controlador) :
                new ObjectParameter("controlador", typeof(string));
    
            var id_menuParameter = id_menu.HasValue ?
                new ObjectParameter("id_menu", id_menu) :
                new ObjectParameter("id_menu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarOpcion", idopcionParameter, opcionParameter, vistaParameter, controladorParameter, id_menuParameter);
        }
    
        public virtual int EditarPrivilegio(Nullable<int> opcion, Nullable<int> rol, Nullable<int> acceder)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            var accederParameter = acceder.HasValue ?
                new ObjectParameter("acceder", acceder) :
                new ObjectParameter("acceder", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarPrivilegio", opcionParameter, rolParameter, accederParameter);
        }
    
        public virtual int EditarRol(Nullable<int> idrol, string rol)
        {
            var idrolParameter = idrol.HasValue ?
                new ObjectParameter("idrol", idrol) :
                new ObjectParameter("idrol", typeof(int));
    
            var rolParameter = rol != null ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarRol", idrolParameter, rolParameter);
        }
    
        public virtual int EditarUsuario(string nombre, string clave, Nullable<int> idrol, string nombrecompleto, Nullable<int> estado, Nullable<int> iduser)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var idrolParameter = idrol.HasValue ?
                new ObjectParameter("idrol", idrol) :
                new ObjectParameter("idrol", typeof(int));
    
            var nombrecompletoParameter = nombrecompleto != null ?
                new ObjectParameter("nombrecompleto", nombrecompleto) :
                new ObjectParameter("nombrecompleto", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            var iduserParameter = iduser.HasValue ?
                new ObjectParameter("iduser", iduser) :
                new ObjectParameter("iduser", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditarUsuario", nombreParameter, claveParameter, idrolParameter, nombrecompletoParameter, estadoParameter, iduserParameter);
        }
    
        public virtual int EliminarMenu(Nullable<int> idemenu)
        {
            var idemenuParameter = idemenu.HasValue ?
                new ObjectParameter("idemenu", idemenu) :
                new ObjectParameter("idemenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarMenu", idemenuParameter);
        }
    
        public virtual int EliminarOpcion(Nullable<int> id_opcion)
        {
            var id_opcionParameter = id_opcion.HasValue ?
                new ObjectParameter("id_opcion", id_opcion) :
                new ObjectParameter("id_opcion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarOpcion", id_opcionParameter);
        }
    
        public virtual int EliminarPrivilegio(Nullable<int> opcion, Nullable<int> rol)
        {
            var opcionParameter = opcion.HasValue ?
                new ObjectParameter("opcion", opcion) :
                new ObjectParameter("opcion", typeof(int));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarPrivilegio", opcionParameter, rolParameter);
        }
    
        public virtual int EliminarRol(Nullable<int> id_rol)
        {
            var id_rolParameter = id_rol.HasValue ?
                new ObjectParameter("id_rol", id_rol) :
                new ObjectParameter("id_rol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarRol", id_rolParameter);
        }
    
        public virtual int EliminarUsuario(Nullable<int> id_usuario)
        {
            var id_usuarioParameter = id_usuario.HasValue ?
                new ObjectParameter("id_usuario", id_usuario) :
                new ObjectParameter("id_usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarUsuario", id_usuarioParameter);
        }
    
        public virtual ObjectResult<GetOpcion_Result> GetOpcion(Nullable<int> idopcion)
        {
            var idopcionParameter = idopcion.HasValue ?
                new ObjectParameter("idopcion", idopcion) :
                new ObjectParameter("idopcion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetOpcion_Result>("GetOpcion", idopcionParameter);
        }
    
        public virtual ObjectResult<ingresoUsuario_Result> ingresoUsuario(string uSUARIO, string cLAVE)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var cLAVEParameter = cLAVE != null ?
                new ObjectParameter("CLAVE", cLAVE) :
                new ObjectParameter("CLAVE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ingresoUsuario_Result>("ingresoUsuario", uSUARIOParameter, cLAVEParameter);
        }
    
        public virtual ObjectResult<string> menus()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("menus");
        }
    
        public virtual ObjectResult<opciones_Result> opciones(string menu, string usuario)
        {
            var menuParameter = menu != null ?
                new ObjectParameter("menu", menu) :
                new ObjectParameter("menu", typeof(string));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<opciones_Result>("opciones", menuParameter, usuarioParameter);
        }
    
        public virtual int registrousuario(string usuario, string nombreCompleto, string clave, Nullable<int> rol)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var nombreCompletoParameter = nombreCompleto != null ?
                new ObjectParameter("nombreCompleto", nombreCompleto) :
                new ObjectParameter("nombreCompleto", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var rolParameter = rol.HasValue ?
                new ObjectParameter("rol", rol) :
                new ObjectParameter("rol", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("registrousuario", usuarioParameter, nombreCompletoParameter, claveParameter, rolParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
