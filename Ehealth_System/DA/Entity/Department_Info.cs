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
    
    public partial class Department_Info
    {
        public string DEPARTMENTID { get; set; }
        public string DEPARTMENTTYPEID { get; set; }
        public string DEPARTMENTNAME { get; set; }
        public string DEPARTMENTDESCRIPTION { get; set; }
        public bool DEPARTMENTSTATUS { get; set; }
    
        public virtual DepartmentType_Info DepartmentType_Info { get; set; }
    }
}
