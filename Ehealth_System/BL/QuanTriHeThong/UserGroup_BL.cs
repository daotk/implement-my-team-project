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
    }
}
