//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataNacional
    {
        public int idNacional { get; set; }
        public Nullable<short> anoMundial { get; set; }
        public string idModalidade { get; set; }
        public Nullable<System.DateTime> iniCompeticao { get; set; }
        public Nullable<System.DateTime> terminoCompeticao { get; set; }
        public string localCompeticao { get; set; }
    
        public virtual Modalidade Modalidade { get; set; }
    }
}