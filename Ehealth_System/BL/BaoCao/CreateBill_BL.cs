using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.BaoCao;
using DA.BaoCao;
namespace BL.BaoCao
{
    //initialize class
    public class CreateBill_BL
    {
        //initialize new constructor to get all cities
        public List<CreateBill_DO> GetAllBill()
        {
            return CreateBill_DA.GetAllBills();
        }

    }//end class
}//end namespace
