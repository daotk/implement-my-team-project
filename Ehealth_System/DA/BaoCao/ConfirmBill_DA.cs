using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BL.BaoCao;
using DO.BaoCao;

namespace DA.BaoCao
{
    public class ConfirmBill_DA
    {
        public static List<ConfirmBill_DO> GetAllBills()
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<ConfirmBill_DO> ListBill = new List<ConfirmBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info select u;
                foreach (var row in query)
                {
                    ConfirmBill_DO bill = new ConfirmBill_DO();
                    bill._BILLID = row.BILLID;
                    bill._PATIENTID = row.PATIENTID;
                    bill._USERID = row.USERID;
                    bill._DESKID = row.DESKID;
                    bill._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    bill._BILLDATE = row.BILLDATE;
                    bill._BILLCOST = row.BILLCOST;
                    bill._BILLSTATUS = row.BILLSTATUS;
                    ListBill.Add(bill);
                }
                //return a list of bill
                return ListBill;
            }
        }
    }
}
