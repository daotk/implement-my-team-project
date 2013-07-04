using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;

namespace BL.ThuNgan
{
    public class Desk_BL
    {
        public static List<DO.ThuNgan.Desk_DO> GetAllDesk()
        {
            return DA.ThuNgan.Desk_DA.GetAllDesk();
        }

        public static List<DO.ThuNgan.Desk_DO> GetDesk(string tenban)
        {
            return DA.ThuNgan.Desk_DA.GetDesk(tenban);
        }

        public static void UpdateCashierInfo(string DeskId, bool check)
        {
            DA.ThuNgan.Desk_DA.UpdateCashierInfo(DeskId, check);
        }

        public static void UpdateTypistInfo(string DeskId, bool check)
        {
            DA.ThuNgan.Desk_DA.UpdateTypistInfo(DeskId, check);
        }
    }
}
