using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO.ThuNgan
{
    public class BillDO {
        public string billid_ { get; set; }
        public string patientid_ { get; set; }
        public string userid_ { get; set; }
        public DateTime billdate_ { get; set; }
        public string billcost_ { get; set; }
        public string deskid_ { get; set; }
        public bool billstatus_ { get; set; }
        public string servicegroupid_ { get; set; }
    }

    public class BillDetailDO
    {
        public string detailbillid_ { get; set; }
        public string serviceid_ { get; set; }
        public string servicecost_ {get;set;}
        public string billid_ { get; set; }
    }
    public class TypistDO
    {
        public string serviceid_ { get; set; }
        public string servicename_ { get; set; }
        public string servicetypeid { get; set; }
        public string servicetypename { get; set; }
        public string servicecost_ { get; set; }
        public string patientid_ { get; set; }
        public string patientname_ { get; set; }
    }
    public class CostDO
    {
        public string serviceid_ { get; set; }
        public string servicecost_ { get; set; }
    }
    public class PatientDO
    {
        public string patientid_ { get; set; }
        public string patientname_ { get; set; }
        public string gender_ { get; set; }
        public string age_ { get; set; }
        public string address_ { get; set; }
        public string phone_ { get; set; }
    }

    public class LoadIDdichvuDO { public string serviceid { get; set; } }
}
