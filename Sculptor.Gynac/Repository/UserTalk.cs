
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
    
public partial class UserTalk
{

    public int Id { get; set; }

    public Nullable<System.DateTime> Enddate { get; set; }

    public Nullable<int> IsActive { get; set; }

    public Nullable<int> IsVideoStatus { get; set; }

    public Nullable<int> IsExamlear { get; set; }

    public Nullable<int> TalkId { get; set; }

    public Nullable<int> UserId { get; set; }

    public Nullable<System.DateTime> CreateDate { get; set; }

    public Nullable<System.DateTime> UpdateDate { get; set; }

    public string Comment { get; set; }

    public Nullable<int> ModuleId { get; set; }

    public Nullable<int> IsModuleClear { get; set; }



    public virtual TalkMaster TalkMaster { get; set; }

    public virtual User User { get; set; }

}

}
