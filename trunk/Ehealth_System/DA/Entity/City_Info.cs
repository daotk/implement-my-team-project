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
    
    public partial class City_Info
    {
        public City_Info()
        {
            this.District_Info = new HashSet<District_Info>();
        }
    
        public string CITYID { get; set; }
        public string CITYNAME { get; set; }
        public string DESCRIPTIONCITY { get; set; }
        public bool STATUSCITY { get; set; }
    
        public virtual ICollection<District_Info> District_Info { get; set; }
    }
}