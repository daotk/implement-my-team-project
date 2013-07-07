using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.BaoCao;
using DA.BaoCao;

namespace BL.BaoCao
{
   public class ConfirmBill_BL
    {
       public List<ConfirmBill_DO> GetAllBill()
       {
           return ConfirmBill_DA.GetAllBills();
       }
    }
}
