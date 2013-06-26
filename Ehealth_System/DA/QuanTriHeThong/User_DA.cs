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
        public static List<User_DO> GetAllUserInfo()
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
                    us._USERTYPEID = row.USERTYPEID;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._EMAIL = row.EMAIL;
                    us._ACCOUNT = row.ACCOUNT;
                    us._PASSWORD = row.PASSWORD;
                    us._AUTHO = row.UserType_Info.AUTHORUZATION;
                    us._STATUS = row.STATUS;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 

 
        public static void InsertUser(string IDUser, string HovaTen, string email,
          string nhomnguoidung, string taikhoan, string password)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                
                

            }
        }

        /// <summary>
        /// Lấy danh sách user tu database theo ma
        /// </summary>
        /// <returns></returns>
        public static List<User_DO> GetUserInfoFollowUserID(string userid)
        {
            List<User_DO> dsUser = new List<User_DO>();
            using (DA.Entity.EHealthSystemEntities dk = new DA.Entity.EHealthSystemEntities())
            {
                var query = from u in dk.User_Info where u.USERID == userid select u;

                foreach (var row in query)
                {
                    User_DO us = new User_DO();
                    us._USERID = row.USERID;
                    us._USERNAME = row.USERNAME;
                    us._USERTYPEID = row.USERTYPEID;
                    us._GROUPUSERNAME = row.UserType_Info.USERTYPENAME;
                    us._EMAIL = row.EMAIL;
                    us._ACCOUNT = row.ACCOUNT;
                    us._PASSWORD = row.PASSWORD;
                    us._AUTHO = row.UserType_Info.AUTHORUZATION;
                    us._STATUS = row.STATUS;
                    dsUser.Add(us);
                }
                return dsUser;
            }
        }//end 

    }
}
