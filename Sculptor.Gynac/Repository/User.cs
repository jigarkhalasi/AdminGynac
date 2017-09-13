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
    
    public partial class User
    {
        public User()
        {
            this.Notifications = new HashSet<Notification>();
            this.UserBookMarks = new HashSet<UserBookMark>();
            this.UserModuleImages = new HashSet<UserModuleImage>();
            this.UserRatings = new HashSet<UserRating>();
            this.UserTalks = new HashSet<UserTalk>();
            this.User_Course = new HashSet<User_Course>();
        }
    
        public int User_Id { get; set; }
        public string Title { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public bool Email_Verified { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Professional_Specialty { get; set; }
        public string Educational_Qualification { get; set; }
        public string Street_Address { get; set; }
        public string City_Town { get; set; }
        public string Country { get; set; }
        public string Institution_Work_Place { get; set; }
        public string Where_Hear { get; set; }
        public string Guid { get; set; }
        public string Transaction_Id { get; set; }
        public string Transaction_Status { get; set; }
        public string Order_Status { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> IsLogin { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public Nullable<bool> IsParticipate { get; set; }
    
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<UserBookMark> UserBookMarks { get; set; }
        public virtual ICollection<UserModuleImage> UserModuleImages { get; set; }
        public virtual ICollection<UserRating> UserRatings { get; set; }
        public virtual ICollection<UserTalk> UserTalks { get; set; }
        public virtual ICollection<User_Course> User_Course { get; set; }
    }
}
