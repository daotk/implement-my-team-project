using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using DO.BaoCao;
namespace DA.BaoCao
{
    //initialize class
    public class CreateBill_DA
    {
        //initialize new constructor to get all bill informations
        public static List<CreateBill_DO> GetAllBills()
        {
            //initialize constructor to get data from Entity model and assign them to grid view
            List<CreateBill_DO> ListBill = new List<CreateBill_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Bill_Info select u;
                foreach (var row in query)
                {
                    CreateBill_DO bill = new CreateBill_DO();
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
      
    }//end class
}//end namespace
