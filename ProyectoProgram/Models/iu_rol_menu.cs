//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class iu_rol_menu
    {
        public int ID_ROL { get; set; }
        public int ID_OPCION { get; set; }
        public Nullable<byte> ACCESO { get; set; }
        public Nullable<byte> AGREGAR { get; set; }
        public Nullable<byte> MODIFICAR { get; set; }
        public Nullable<byte> ELIMINAR { get; set; }
    
        public virtual iu_opcion iu_opcion { get; set; }
        public virtual iu_rol iu_rol { get; set; }
    }
}
