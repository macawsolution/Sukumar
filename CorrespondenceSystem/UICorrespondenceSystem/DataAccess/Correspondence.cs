//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UICorrespondenceSystem.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Correspondence
    {
        public int Id { get; set; }
        public string Serial_Number { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<byte> Sender_Type { get; set; }
        public Nullable<int> Sender_Internal_Id { get; set; }
        public Nullable<int> Sender_External_Id { get; set; }
        public Nullable<System.DateTime> Sender_Creation_Date { get; set; }
        public Nullable<System.DateTime> Received_Date { get; set; }
        public Nullable<System.DateTime> Final_Reply_Date { get; set; }
        public Nullable<int> Entity_Person_Id { get; set; }
        public Nullable<int> Correspondence_Type { get; set; }
        public Nullable<int> Expected_Reply_Within_Days { get; set; }
        public string Status { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
    }
}
