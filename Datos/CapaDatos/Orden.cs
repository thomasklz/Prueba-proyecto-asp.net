//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orden
    {
        public Orden()
        {
            this.Orden_Detalle = new HashSet<Orden_Detalle>();
        }
    
        public int IdOrden { get; set; }
        public System.DateTime FechaOrden { get; set; }
        public System.DateTime FechaEntrada { get; set; }
    
        public virtual ICollection<Orden_Detalle> Orden_Detalle { get; set; }
    }
}