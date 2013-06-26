using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class User_BL
    {
        /// <summary>
        /// kiem tra username va password co hop le khong.
        /// </summary>
        /// <returns></returns>
        public static bool CheckLogin(string username, string password)
        {
            bool check = false;
            List<User_DO> ds = DA.QuanTriHeThong.User_DA.GetAllUsers();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i]._ACCOUNT == username && ds[i]._PASSWORD == password)
                {
                    BL.StaticClass.GroupUser = ds[i]._GROUPUSERNAME;
                    BL.StaticClass.UserName = ds[i]._USERNAME;
                    BL.StaticClass.Authorization = ds[i]._AUTHO;

                    check = true;
                }
            }
            return check;
        }

        /// <summary>
        /// tra ve ds user dang co trong database
        /// </summary>
        /// <returns></returns>
        public static List<User_DO> GetAllUSer()
        {
            return DA.QuanTriHeThong.User_DA.GetAllUsers();
        }

        /// <summary>
        /// tra ve ds user info dang co trong database
        /// </summary>
        /// <returns></returns>
        public static List<User1_DO> GetUSerInfo()
        {
            return DA.QuanTriHeThong.User_DA.GetUserInfo();
        }


    }
}
