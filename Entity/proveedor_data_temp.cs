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
    
    public partial class proveedor_data_temp
    {
        public int idData { get; set; }
        public int numVentas { get; set; }
        public int activo { get; set; }
        public int idUser { get; set; }
    
        public virtual tb_usuario tb_usuario { get; set; }
        public virtual tb_usuario tb_usuario1 { get; set; }
        public virtual tb_usuario tb_usuario2 { get; set; }
        public virtual tb_usuario tb_usuario3 { get; set; }
    }
}
