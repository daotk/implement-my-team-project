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
            List<User_DO> ds = DA.QuanTriHeThong.User_DA.GetAllUserInfo();
            for (int i = 0; i < ds.Count; i++)
            {
                    if (ds[i]._ACCOUNT == username && ds[i]._PASSWORD == password)
                    {
                        BL.StaticClass.UserID = ds[i]._USERID;
                        BL.StaticClass.GroupUser = ds[i]._GROUPUSERNAME;
                        BL.StaticClass.UserName = ds[i]._USERNAME;
                        BL.StaticClass.Authorization = ds[i]._AUTHO;
                        BL.StaticClass.StatusUser = ds[i]._STATUS;
                        check = true;
                    }
            }
            return check;
        }

        /// <summary>
        /// tra ve ds user dang co trong database
        /// </summary>
        /// <returns></returns>
        public static List<User_DO> GetAllUserInfo()
        {
            return DA.QuanTriHeThong.User_DA.GetAllUserInfo();
        }


        public static List<DO.QuanTriHeThong.UserGroup_DO> GetAllUser1()
        {
            return DA.QuanTriHeThong.User_DA.GetAllUser1();
        }
        /// <summary>
        /// tra ve ds user info dang co trong database theo ma user
        /// </summary>
        /// <returns></returns>
        public static List<User_DO> GetUSerInfoFollowUserID(string userid)
        {
            return DA.QuanTriHeThong.User_DA.GetUserInfoFollowUserID(userid);
        }

        public static void InsertUser(string IdUser, string hovaten, string email,
          string nhomnguoidung, string taikhoan, string password,bool status)
        {
            DA.QuanTriHeThong.User_DA.InsertUser(IdUser, hovaten, email, nhomnguoidung, taikhoan, password,status);
        }
        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="IdUser"></param>
        /// <param name="hovaten"></param>
        /// <param name="email"></param>
        /// <param name="nhomnguoidung"></param>
        /// <param name="taikhoan"></param>
        /// <param name="password"></param>
        /// <param name="status"></param>
        public static void UpdateUser(string IdUser, string hovaten, string email,
         string nhomnguoidung, string taikhoan, string matkhau, bool status)
        {
            DA.QuanTriHeThong.User_DA.UpdateUser(IdUser, hovaten, email, nhomnguoidung, taikhoan, matkhau, status);
        }
        //
        public static void ChangePassword(string IdUser, string password)
        {
            DA.QuanTriHeThong.User_DA.ChangePassword(IdUser, password);
        }

    }
}
