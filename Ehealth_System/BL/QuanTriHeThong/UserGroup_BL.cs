using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class UserGroup_BL
    {
        public static List<UserGroup_DO> GetAllUsserGroup() {
            return DA.QuanTriHeThong.UserGroup_DA.GetAllUserGroup();
        }
        //Create user group
        public static void CreateUserGroup(string tenviettats, string tennhoms, string motas,string authorization
            , bool trangthais)
        {
            DA.QuanTriHeThong.UserGroup_DA.CreateUserGroup(tenviettats, tennhoms, motas,authorization, trangthais);
        }
        // End create user group
        
        //Get info user group
        public static List<UserGroup_DO> GetUserGroup(string tenviettat)
        {
            return DA.QuanTriHeThong.UserGroup_DA.GetUserGroup(tenviettat);
        }
        //End get info user group
        //Edit Information of User Group

        public static void EditUserGroup(string Tenviettat, string Tennhom, string Mota
            , bool Trangthai)
        {
            DA.QuanTriHeThong.UserGroup_DA.EditUserGroup(Tenviettat, Tennhom, Mota, Trangthai);
        }
        //End Edit user group
        //Check info user group
        public static List<UserGroup_DO> CheckInfo()
        {
            return DA.QuanTriHeThong.UserGroup_DA.CheckInfo();
        }
        //End Check 

        //Check Edit Info
        public static List<UserGroup_DO> CheckEditInfo(string tenhientai)
        {
            return DA.QuanTriHeThong.UserGroup_DA.CheckEditInfo(tenhientai);
        }
        //End Check
        //Edit authorization of User Group

        public static void EditAuthorization(string tenviettata, string author)
        {
            DA.QuanTriHeThong.UserGroup_DA.EditAuthorization(tenviettata, author);
        }
        //End Edit authorization of user group

        public static List<UserGroup_DO> LoadAuthorization(string manguoidung)
        {
            return DA.QuanTriHeThong.UserGroup_DA.LoadAuthorization(manguoidung);
        }// End
    }

}
