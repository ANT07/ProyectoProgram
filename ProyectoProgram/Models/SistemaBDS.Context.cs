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
    
    public partial class SistemaContableEntities1 : DbContext
    {
        public SistemaContableEntities1()
            : base("name=SistemaContableEntities1")
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
        public virtual DbSet<VistaUsuario> VistaUsuarios { get; set; }
        public virtual DbSet<VistaRole> VistaRoles { get; set; }
    
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
    }
}