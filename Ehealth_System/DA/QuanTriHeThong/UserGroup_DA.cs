using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
namespace DA.QuanTriHeThong
{
    public class UserGroup_DA
    {
        public static List<UserGroup_DO> GetAllUserGroup() {
            List<UserGroup_DO> dsusergroup = new List<UserGroup_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info select u;
                foreach (var row in query) {
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
    }
}
