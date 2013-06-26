using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA.QuanTriHeThong
{
    public class User_DA
    {
        /// <summary>
        /// Lấy danh sách user tu database
        /// </summary>
        /// <returns></returns>
        public static List<User_DO> GetAllUsers()
        {
            List<User_DO> dsUser = new List<User_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info select u;

                foreach (var row in query)
                {
                    User_DO us = new User_DO();
                    us._USERID = row.USERID;
                    us._USERNAME = row.USERNAME;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._EMAIL = row.EMAIL;
                    us._ACCOUNT = row.ACCOUNT;
                    us._PASSWORD = row.PASSWORD;
                    us._AUTHO = row.UserType_Info.AUTHORUZATION;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 

        /// <summary>
        /// Lấy danh sách user tu database
        /// </summary>
        /// <returns></returns>
        public static List<User1_DO> GetUserInfo()
        {
            List<User1_DO> dsUser = new List<User1_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info select u;

                foreach (var row in query)
                {
                    User1_DO us = new User1_DO();
                    us._USERID = row.USERID;
                    us._USERNAME = row.USERNAME;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._ACCOUNT = row.ACCOUNT;
                    us._STATUS = row.STATUS;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 


    }
}
