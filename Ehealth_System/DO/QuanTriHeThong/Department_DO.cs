using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace DO.QuanTriHeThong
{
   public class Department_DO
    {
        public string _DEPARTMENTID { set; get; }
        public string _DEPARTMENTNAME { set; get; }
        public string _DEPARTMENTTYPEID { set; get; }
        public string _DEPARTMENTTYPENAME { set; get; }
        public string _DEPARTMENTDESCRIPTION { set; get; }
        public bool   _DEPARTMENTSTATUS { set; get; }
    }
}
