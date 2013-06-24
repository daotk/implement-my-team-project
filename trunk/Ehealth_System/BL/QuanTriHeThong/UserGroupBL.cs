using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
    public class UserGroupBL
    {
        public static List<UserGroupDO> GetAllUsserGroup() {
            return DA.QuanTriHeThong.UserGroupDA.GetAllUserGroup();
        }
    }
}
