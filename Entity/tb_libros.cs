//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopBook.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_libros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_libros()
        {
            this.tb_cate_subcate_libros = new HashSet<tb_cate_subcate_libros>();
            this.tb_detalle_boletas = new HashSet<tb_detalle_boletas>();
        }
    
        public int idLibro { get; set; }
        public string tituLibro { get; set; }
        public string nomAutor { get; set; }
        public string sinopsis { get; set; }
        public Nullable<decimal> precUni { get; set; }
        public Nullable<int> idEdito { get; set; }
        public Nullable<int> estado { get; set; }
        public string img { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_cate_subcate_libros> tb_cate_subcate_libros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_detalle_boletas> tb_detalle_boletas { get; set; }
        public virtual tb_editoriales tb_editoriales { get; set; }
    }
}
