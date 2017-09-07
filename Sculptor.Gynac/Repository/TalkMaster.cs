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
    
    public partial class TalkMaster
    {
        public TalkMaster()
        {
            this.QuestionMasters = new HashSet<QuestionMaster>();
            this.UserTalks = new HashSet<UserTalk>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string VideoLink { get; set; }
        public Nullable<int> FacultyId { get; set; }
        public Nullable<int> ModulId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string PreViewVideoLink { get; set; }
        public string Talkdesc { get; set; }
        public string Duration { get; set; }
        public string BackupVideoLink { get; set; }
    
        public virtual ICollection<QuestionMaster> QuestionMasters { get; set; }
        public virtual SessionMaster SessionMaster { get; set; }
        public virtual ICollection<UserTalk> UserTalks { get; set; }
        public virtual ModuleMaster ModuleMaster { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
