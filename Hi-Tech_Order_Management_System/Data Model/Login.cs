//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hi_Tech_Order_Management_System.Data_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Login
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public int LoginId { get; set; }
    
        public virtual User User { get; set; }
    }
}