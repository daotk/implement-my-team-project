//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Info
    {
        public User_Info()
        {
            this.Bill_Info = new HashSet<Bill_Info>();
        }
    
        public string USERID { get; set; }
        public string USERTYPEID { get; set; }
        public string ACCOUNT { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool STATUS { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<Bill_Info> Bill_Info { get; set; }
        public virtual UserType_Info UserType_Info { get; set; }
    }
}