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
    
    public partial class tblmaestropartida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmaestropartida()
        {
            this.tbldetallepartidas = new HashSet<tbldetallepartida>();
            this.tblmovimientoes = new HashSet<tblmovimiento>();
        }
    
        public string IDPARTIDA { get; set; }
        public Nullable<int> ID_USUARIO { get; set; }
        public System.DateTime FECHACREACION { get; set; }
        public string CONCEPTOPARTIDA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbldetallepartida> tbldetallepartidas { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblmovimiento> tblmovimientoes { get; set; }
    }
}
