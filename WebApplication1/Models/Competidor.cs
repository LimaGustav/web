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
    
    public partial class Competidor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competidor()
        {
            this.Notas = new HashSet<Notas>();
        }
    
        public int idCompetidor { get; set; }
        public string idModalidade { get; set; }
        public string Nome { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> dataNascimento { get; set; }
    
        public virtual Estados Estados { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notas> Notas { get; set; }
    }
}