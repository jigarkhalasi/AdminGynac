//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sculptor.Gynac.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class SessionMaster
    {
        public SessionMaster()
        {
            this.TalkMasters = new HashSet<TalkMaster>();
            this.ModuleMasters = new HashSet<ModuleMaster>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<TalkMaster> TalkMasters { get; set; }
        public virtual ICollection<ModuleMaster> ModuleMasters { get; set; }
    }
}
