
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
    
public partial class Notification
{

    public int Id { get; set; }

    public string Comment { get; set; }

    public Nullable<int> IsRead { get; set; }

    public Nullable<int> FacultyId { get; set; }

    public Nullable<int> UserId { get; set; }

    public Nullable<System.DateTime> CreateDate { get; set; }

    public Nullable<System.DateTime> UpdateDate { get; set; }



    public virtual Faculty Faculty { get; set; }

    public virtual User User { get; set; }

}

}
