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
    }
}
