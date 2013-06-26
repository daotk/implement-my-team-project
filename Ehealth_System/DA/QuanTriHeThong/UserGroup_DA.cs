using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
namespace DA.QuanTriHeThong
{
    public class UserGroup_DA
    {
        //View list user group
        public static List<UserGroup_DO> GetAllUserGroup()
        {
            List<UserGroup_DO> dsusergroup = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info select u;
                foreach (var row in query)
                {
                    UserGroup_DO us = new UserGroup_DO();
                    us.tenviettat_ = row.USERTYPEID;
                    us.tennhom_ = row.USERTYPENAME;
                    us.trangthai = row.USERTYPESTATUS;
                    us.mota_ = row.DESCRIPTION;

                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
        //Create user group
        public static void CreateUserGroup(string tenviettats, string tennhoms, string motas, string authorization
            , bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.UserType_Info user = new Entity.UserType_Info();
                user.USERTYPEID = tenviettats;
                user.USERTYPENAME = tennhoms;
                user.DESCRIPTION = motas;
                user.AUTHORUZATION = authorization;
                user.USERTYPESTATUS = trangthais;
                dk.UserType_Info.AddObject(user);
                dk.SaveChanges();
            }
        }
        // End create user group
        //Edit Information of User Group
        
        public static void EditUserGroup(string tenviettats, string tennhoms, string motas
            , bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.UserType_Info
                             where u.USERTYPEID == tenviettats
                             select u).First();
                query.USERTYPEID = tenviettats;
                query.USERTYPENAME = tennhoms ;
                query.DESCRIPTION = motas;
                query.USERTYPESTATUS = trangthais;
                

                dk.SaveChanges();
            }
        }
        //End Edit user group
        
        //Get info user group
        public static List<UserGroup_DO> GetUserGroup(string tenviettats)
        {
            List<UserGroup_DO> dsusergroup = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info where u.USERTYPEID == tenviettats select u;
                foreach (var row in query)
                {
                    UserGroup_DO us = new UserGroup_DO();
                    us.tenviettat_ = row.USERTYPEID;
                    us.tennhom_ = row.USERTYPENAME;
                    us.trangthai = row.USERTYPESTATUS;
                    us.mota_ = row.DESCRIPTION;

                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
        //End Get info user group

        //Check Infor of user group
        public static List<UserGroup_DO> CheckInfo()
        {
            List<UserGroup_DO> dsmanguoidung = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info select u;
                foreach (var row in query)
                {
                    UserGroup_DO us = new UserGroup_DO();
                    us.tenviettat_ = row.USERTYPEID;
                    us.tennhom_ = row.USERTYPENAME;
                    dsmanguoidung.Add(us);
                }
            }
            return dsmanguoidung;
        }
        //End Check
        //Check Edit Info
        public static List<UserGroup_DO> CheckEditInfo(string tenhientai)
        {
            List<UserGroup_DO> dsmanguoidung = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info where u.USERTYPENAME != tenhientai select u;
                foreach (var row in query)
                {
                    UserGroup_DO us = new UserGroup_DO();
                    us.tennhom_ = row.USERTYPENAME;
                    dsmanguoidung.Add(us);
                }
            }
            return dsmanguoidung;
        }
        //End Check

        //Edit authorization of User Group

        public static void EditAuthorization(string tenviettata,string author)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                
                var query = (from u in dk.UserType_Info
                             where u.USERTYPEID == tenviettata
                             select u).First();
                query.USERTYPEID = tenviettata;
                query.AUTHORUZATION = author;
                
                dk.SaveChanges();
            }
        }
        //End Edit authorization of user group

        public static List<UserGroup_DO> LoadAuthorization(string manguoidung)
        {
            List<UserGroup_DO> dsusergroup = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info where u.USERTYPEID == manguoidung select u;
                foreach (var row in query)
                {
                    UserGroup_DO us = new UserGroup_DO();
                    us.author_ = row.AUTHORUZATION;
                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }
    }
}
