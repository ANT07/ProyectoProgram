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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.tblmaestropartidas = new HashSet<tblmaestropartida>();
        }
    
        public int ID_USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string CLAVE { get; set; }
        public int ID_ROL { get; set; }
        public string NOMBRE_COMPLETO { get; set; }
        public Nullable<byte> ESTADO { get; set; }
    
        public virtual iu_rol iu_rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblmaestropartida> tblmaestropartidas { get; set; }
    }
}
