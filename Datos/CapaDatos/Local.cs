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
    
    public partial class Local
    {
        public Local()
        {
            this.Guia = new HashSet<Guia>();
        }
    
        public int IdLocal { get; set; }
        public string Direccion { get; set; }
        public string Distrito { get; set; }
        public Nullable<int> Telefono { get; set; }
    
        public virtual ICollection<Guia> Guia { get; set; }
    }
}