using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using DO;

namespace BL.QuanTriHeThong
{
    public class Desk_BL
    {
        public static List<DO.QuanTriHeThong.Desk_DO> GetDesk(string id)
        {
            return DA.QuanTriHeThong.Desk_DA.GetDesk(id);
        }

    }
}
