//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelpdeskEspecialista.BD
{
    using System;
    using System.Collections.Generic;
    
    public partial class SintomaLog
    {
        public int Id { get; set; }
        public Nullable<int> ProblemaSintomaId { get; set; }
        public Nullable<short> SeUtil { get; set; }
    
        public virtual ProblemaSintoma ProblemaSintoma { get; set; }
    }
}