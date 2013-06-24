using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
namespace DA.QuanTriHeThong
{
    public class UserGroupDA
    {
        public static List<UserGroupDO> GetAllUserGroup() {
            List<UserGroupDO> dsusergroup = new List<UserGroupDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.UserType_Info select u;
                foreach (var row in query) {
                    UserGroupDO us = new UserGroupDO();
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
