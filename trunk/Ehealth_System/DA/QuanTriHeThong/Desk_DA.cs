using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;

namespace DA.QuanTriHeThong
{
    public class Desk_DA
    {
        /// <summary>
        /// Lấy danh sách user tu database
        /// </summary>
        /// <returns></returns>
        public static List<DO.QuanTriHeThong.Desk_DO> GetDesk(string departmentid)
        {
            List<DO.QuanTriHeThong.Desk_DO> dsUser = new List<DO.QuanTriHeThong.Desk_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DeskCashiers where u.DEPARTMENTID == departmentid select u;

                foreach (var row in query)
                {
                    DO.QuanTriHeThong.Desk_DO us = new DO.QuanTriHeThong.Desk_DO();
                    us._DESKID = row.DESKID;
                    us._DEPARTMENTID = row.DEPARTMENTID;
                    us._DESKNAME = row.DESKNAME;
                    us._DESKSTATUS = row.DESKSTATUS;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 
    }
}
