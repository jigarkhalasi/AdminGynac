
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
    
public partial class Faculty
{

    public Faculty()
    {

        this.Courses = new HashSet<Course>();

        this.ModuleMasters = new HashSet<ModuleMaster>();

        this.Notifications = new HashSet<Notification>();

        this.TalkMasters = new HashSet<TalkMaster>();

        this.UserModuleImages = new HashSet<UserModuleImage>();

    }


    public int Faculty_Id { get; set; }

    public string Title { get; set; }

    public string Name { get; set; }

    public string Image { get; set; }

    public string Profile_Summary { get; set; }

    public System.DateTime Insert_Date { get; set; }

    public System.DateTime Update_Date { get; set; }

    public string ProfilePic { get; set; }

    public string Email { get; set; }

    public string AspNetUsersId { get; set; }



    public virtual AspNetUser AspNetUser { get; set; }

    public virtual ICollection<Course> Courses { get; set; }

    public virtual ICollection<ModuleMaster> ModuleMasters { get; set; }

    public virtual ICollection<Notification> Notifications { get; set; }

    public virtual ICollection<TalkMaster> TalkMasters { get; set; }

    public virtual ICollection<UserModuleImage> UserModuleImages { get; set; }

}

}
