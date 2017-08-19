﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GynacEntities : DbContext
    {
        public GynacEntities()
            : base("name=GynacEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<ModuleImage> ModuleImages { get; set; }
        public virtual DbSet<QuestionMaster> QuestionMasters { get; set; }
        public virtual DbSet<QuetionOptionMaster> QuetionOptionMasters { get; set; }
        public virtual DbSet<SessionMaster> SessionMasters { get; set; }
        public virtual DbSet<TalkMaster> TalkMasters { get; set; }
        public virtual DbSet<User_Course> User_Course { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<UserTalk> UserTalks { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<ModuleMaster> ModuleMasters { get; set; }
        public virtual DbSet<UserModuleImage> UserModuleImages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
    
        public virtual ObjectResult<Nullable<int>> Activate_User_Course(string guid, string transactionId, string transactionStatus, string orderStatus)
        {
            var guidParameter = guid != null ?
                new ObjectParameter("Guid", guid) :
                new ObjectParameter("Guid", typeof(string));
    
            var transactionIdParameter = transactionId != null ?
                new ObjectParameter("TransactionId", transactionId) :
                new ObjectParameter("TransactionId", typeof(string));
    
            var transactionStatusParameter = transactionStatus != null ?
                new ObjectParameter("TransactionStatus", transactionStatus) :
                new ObjectParameter("TransactionStatus", typeof(string));
    
            var orderStatusParameter = orderStatus != null ?
                new ObjectParameter("OrderStatus", orderStatus) :
                new ObjectParameter("OrderStatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Activate_User_Course", guidParameter, transactionIdParameter, transactionStatusParameter, orderStatusParameter);
        }
    
        public virtual int Delete_User_Course(Nullable<int> user_Id)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_User_Course", user_IdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Email_Verified(string guid, string email)
        {
            var guidParameter = guid != null ?
                new ObjectParameter("Guid", guid) :
                new ObjectParameter("Guid", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Email_Verified", guidParameter, emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Forgot_Password(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Forgot_Password", emailParameter);
        }
    
        public virtual ObjectResult<Get_All_Course_Result> Get_All_Course()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_All_Course_Result>("Get_All_Course");
        }
    
        public virtual ObjectResult<Nullable<int>> Get_Total_Course_Cost(string guid)
        {
            var guidParameter = guid != null ?
                new ObjectParameter("Guid", guid) :
                new ObjectParameter("Guid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Get_Total_Course_Cost", guidParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Insert_User(string title, string first_Name, string middle_Name, string last_Name, string email, Nullable<bool> email_Verified, string mobile, string password, string professional_Specialty, string educational_Qualification, string street_Address, string city_Town, string country, string institution_Work_Place, string where_Hear)
        {
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("First_Name", first_Name) :
                new ObjectParameter("First_Name", typeof(string));
    
            var middle_NameParameter = middle_Name != null ?
                new ObjectParameter("Middle_Name", middle_Name) :
                new ObjectParameter("Middle_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("Last_Name", last_Name) :
                new ObjectParameter("Last_Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var email_VerifiedParameter = email_Verified.HasValue ?
                new ObjectParameter("Email_Verified", email_Verified) :
                new ObjectParameter("Email_Verified", typeof(bool));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var professional_SpecialtyParameter = professional_Specialty != null ?
                new ObjectParameter("Professional_Specialty", professional_Specialty) :
                new ObjectParameter("Professional_Specialty", typeof(string));
    
            var educational_QualificationParameter = educational_Qualification != null ?
                new ObjectParameter("Educational_Qualification", educational_Qualification) :
                new ObjectParameter("Educational_Qualification", typeof(string));
    
            var street_AddressParameter = street_Address != null ?
                new ObjectParameter("Street_Address", street_Address) :
                new ObjectParameter("Street_Address", typeof(string));
    
            var city_TownParameter = city_Town != null ?
                new ObjectParameter("City_Town", city_Town) :
                new ObjectParameter("City_Town", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var institution_Work_PlaceParameter = institution_Work_Place != null ?
                new ObjectParameter("Institution_Work_Place", institution_Work_Place) :
                new ObjectParameter("Institution_Work_Place", typeof(string));
    
            var where_HearParameter = where_Hear != null ?
                new ObjectParameter("Where_Hear", where_Hear) :
                new ObjectParameter("Where_Hear", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Insert_User", titleParameter, first_NameParameter, middle_NameParameter, last_NameParameter, emailParameter, email_VerifiedParameter, mobileParameter, passwordParameter, professional_SpecialtyParameter, educational_QualificationParameter, street_AddressParameter, city_TownParameter, countryParameter, institution_Work_PlaceParameter, where_HearParameter);
        }
    
        public virtual ObjectResult<Insert_User_Course_Result> Insert_User_Course(Nullable<int> user_Id, Nullable<int> course_Id, Nullable<System.DateTime> registered_Date, Nullable<System.DateTime> registered_Till, string payment_Mode, Nullable<decimal> payment_Amount, string payment_Currency)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var course_IdParameter = course_Id.HasValue ?
                new ObjectParameter("Course_Id", course_Id) :
                new ObjectParameter("Course_Id", typeof(int));
    
            var registered_DateParameter = registered_Date.HasValue ?
                new ObjectParameter("Registered_Date", registered_Date) :
                new ObjectParameter("Registered_Date", typeof(System.DateTime));
    
            var registered_TillParameter = registered_Till.HasValue ?
                new ObjectParameter("Registered_Till", registered_Till) :
                new ObjectParameter("Registered_Till", typeof(System.DateTime));
    
            var payment_ModeParameter = payment_Mode != null ?
                new ObjectParameter("Payment_Mode", payment_Mode) :
                new ObjectParameter("Payment_Mode", typeof(string));
    
            var payment_AmountParameter = payment_Amount.HasValue ?
                new ObjectParameter("Payment_Amount", payment_Amount) :
                new ObjectParameter("Payment_Amount", typeof(decimal));
    
            var payment_CurrencyParameter = payment_Currency != null ?
                new ObjectParameter("Payment_Currency", payment_Currency) :
                new ObjectParameter("Payment_Currency", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Insert_User_Course_Result>("Insert_User_Course", user_IdParameter, course_IdParameter, registered_DateParameter, registered_TillParameter, payment_ModeParameter, payment_AmountParameter, payment_CurrencyParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Reset_Password(string email, string password, string guid)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var guidParameter = guid != null ?
                new ObjectParameter("Guid", guid) :
                new ObjectParameter("Guid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Reset_Password", emailParameter, passwordParameter, guidParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Update_User(Nullable<int> user_Id, string title, string first_Name, string middle_Name, string last_Name, string email, Nullable<bool> email_Verified, string mobile, string password, string professional_Specialty, string educational_Qualification, string street_Address, string city_Town, string country, string institution_Work_Place, string where_Hear)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("First_Name", first_Name) :
                new ObjectParameter("First_Name", typeof(string));
    
            var middle_NameParameter = middle_Name != null ?
                new ObjectParameter("Middle_Name", middle_Name) :
                new ObjectParameter("Middle_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("Last_Name", last_Name) :
                new ObjectParameter("Last_Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var email_VerifiedParameter = email_Verified.HasValue ?
                new ObjectParameter("Email_Verified", email_Verified) :
                new ObjectParameter("Email_Verified", typeof(bool));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var professional_SpecialtyParameter = professional_Specialty != null ?
                new ObjectParameter("Professional_Specialty", professional_Specialty) :
                new ObjectParameter("Professional_Specialty", typeof(string));
    
            var educational_QualificationParameter = educational_Qualification != null ?
                new ObjectParameter("Educational_Qualification", educational_Qualification) :
                new ObjectParameter("Educational_Qualification", typeof(string));
    
            var street_AddressParameter = street_Address != null ?
                new ObjectParameter("Street_Address", street_Address) :
                new ObjectParameter("Street_Address", typeof(string));
    
            var city_TownParameter = city_Town != null ?
                new ObjectParameter("City_Town", city_Town) :
                new ObjectParameter("City_Town", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var institution_Work_PlaceParameter = institution_Work_Place != null ?
                new ObjectParameter("Institution_Work_Place", institution_Work_Place) :
                new ObjectParameter("Institution_Work_Place", typeof(string));
    
            var where_HearParameter = where_Hear != null ?
                new ObjectParameter("Where_Hear", where_Hear) :
                new ObjectParameter("Where_Hear", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Update_User", user_IdParameter, titleParameter, first_NameParameter, middle_NameParameter, last_NameParameter, emailParameter, email_VerifiedParameter, mobileParameter, passwordParameter, professional_SpecialtyParameter, educational_QualificationParameter, street_AddressParameter, city_TownParameter, countryParameter, institution_Work_PlaceParameter, where_HearParameter);
        }
    
        public virtual int Update_User_Email_Verification(Nullable<int> user_Id, string email)
        {
            var user_IdParameter = user_Id.HasValue ?
                new ObjectParameter("User_Id", user_Id) :
                new ObjectParameter("User_Id", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Update_User_Email_Verification", user_IdParameter, emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> Verify_User(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("Verify_User", emailParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Verify_User_By_Guid_Result> Verify_User_By_Guid(string guid)
        {
            var guidParameter = guid != null ?
                new ObjectParameter("Guid", guid) :
                new ObjectParameter("Guid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Verify_User_By_Guid_Result>("Verify_User_By_Guid", guidParameter);
        }
    }
}
