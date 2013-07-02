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


        public static List<DO.QuanTriHeThong.Desk_DO> GetAllDesk()
        {
            return DA.QuanTriHeThong.Desk_DA.GetAllDesk();
        }
        /// <summary>
        /// thêm mới bàn thu ngân
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="departID"></param>
        /// <param name="name"></param>
        /// <param name="desscription"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static void add(string ID,  string name ,string departID, bool status)
        {

             DA.QuanTriHeThong.Desk_DA.add(ID,  name ,departID, status);

        }//end

        public static int edit(String ID, String name , bool status)
        {

           return DA.QuanTriHeThong.Desk_DA.edit(ID, name, status);

        }
    }
}
