using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO;
using System.Data.Entity;
using System.Data.Objects;

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



        public static List<DO.QuanTriHeThong.Desk_DO> GetAllDesk()
        {
            List<DO.QuanTriHeThong.Desk_DO> dsUser = new List<DO.QuanTriHeThong.Desk_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DeskCashiers select u;

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
        /// <summary>
        /// Thêm mới bàn thu ngân
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="departID"></param>
        /// <param name="name"></param>
        /// <param name="desscription"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static void add(string ID, string name, string departID, bool status)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.DeskCashier desk = new Entity.DeskCashier();
                desk.DESKID = ID;
                desk.DESKNAME = name;
                desk.DEPARTMENTID = departID;
                desk.DESKSTATUS = status;
                dk.DeskCashiers.AddObject(desk);
                dk.SaveChanges();
            }
        }

        public static int edit(String ID, String name, bool status)
        {

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                var depart = entity.DeskCashiers.Single(p => p.DESKID == ID);

                depart.DESKID = ID;
                depart.DESKNAME = name;
                depart.DESKSTATUS = status;

                //entity.SaveChanges();
                try
                {
                    int num = entity.SaveChanges();
                    return num;
                }
                catch
                {
                    return -1;
                }

            }
        }//end
    }
}
