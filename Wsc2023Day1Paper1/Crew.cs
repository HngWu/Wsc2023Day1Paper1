//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wsc2023Day1Paper1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Crew
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Crew()
        {
            this.TeamAssigneds = new HashSet<TeamAssigned>();
        }
    
        public int Crew_Number { get; set; }
        public string Gender { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Home_Port_IATA { get; set; }
    
        public virtual Airport Airport { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TeamAssigned> TeamAssigneds { get; set; }
    }
}
