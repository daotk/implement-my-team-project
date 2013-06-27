using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class GroupService_BL
    {
        public static List<GroupService_DO> GetGroupService()
        {
            return DA.QuanTriHeThong.GroupService_DA.GetGroupService();
        }
        public static void CreateService(string serviceid, string servicename, string servicedescription, bool trangthais)
        {
            DA.QuanTriHeThong.GroupService_DA.CreateService(serviceid, servicename, servicedescription, trangthais);
        }
        public static void EditService(string serviceid, string servicename, string servicedescription, bool trangthais)
        {
            DA.QuanTriHeThong.GroupService_DA.EditService(serviceid, servicename, servicedescription, trangthais);
        }
        public static List<GroupService_DO> Get_GroupService(string tenviettats)
        {
            return DA.QuanTriHeThong.GroupService_DA.Get_GroupService(tenviettats);
        }
    }
}
