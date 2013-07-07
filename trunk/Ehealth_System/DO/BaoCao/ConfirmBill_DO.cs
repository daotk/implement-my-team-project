using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DO.BaoCao
{
    public class ConfirmBill_DO
    {
        public string _BILLID { set; get; }
        public string _PATIENTID { set; get; }
        public string _USERID { set; get; }
        public string _DESKID { set; get; }
        public string _SERVICEGROUPNAME { set; get; }
        public DateTime _BILLDATE { set; get; }
        public string _BILLCOST { set; get; }
        public bool _BILLSTATUS { set; get; }
    }//end class
}//end namespace
