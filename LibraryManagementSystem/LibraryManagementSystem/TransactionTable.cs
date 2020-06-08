//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionTable
    {
        public int TransactionID { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan Time { get; set; }
        public string BorrowerID { get; set; }
        public string BookID { get; set; }
        public string IssuedBy { get; set; }
        public string Returned_ { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual LibraryStaff LibraryStaff { get; set; }
        public virtual Patron Patron { get; set; }
    }
}