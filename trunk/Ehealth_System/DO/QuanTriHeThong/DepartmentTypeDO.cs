using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;

namespace DO.QuanTriHeThong
{
   
    public class DepartmentTypeDO
    {
        public string _DEPARTMENTTYPEID { set; get; }
        public string _DEPARTMENTNAME { set; get; }
        public string _DEPARTMENTDESCRIPTION { set; get; }
        public bool   _DEPARTMENTSTATUS { set; get; }
          
    }
}

