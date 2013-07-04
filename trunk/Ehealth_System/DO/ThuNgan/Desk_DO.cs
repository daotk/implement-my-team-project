using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO.ThuNgan
{
    public class Desk_DO
    {
        public string _DESKID{set;get;}
        public string _DEPARTMENTID{set;get;}
        public string _DEPARTMENTNAME { set; get; }
        public string _DESKNAME{set;get;}
        public bool? _CASHIER { set; get; }
        public bool? _TYPIST { set; get; }
        public bool? _DESKSTATUS { set; get; }
    }
}
