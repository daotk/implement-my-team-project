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
        /// <summary>
        /// load danh sach nhom dich vu
        /// </summary>
        /// <returns></returns>
        public static List<GroupService_DO> GetGroupService()
        {
            return DA.QuanTriHeThong.GroupService_DA.GetGroupService();
        }
        /// <summary>
        /// tao/them moi mot nhom dich vu
        /// </summary>
        /// <param name="GroupService"></param>
        /// <param name="GroupServiceName"></param>
        /// <param name="GroupServiceDescription"></param>
        /// <param name="GroupServiceStatus"></param>
        public static void CreateGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            DA.QuanTriHeThong.GroupService_DA.CreateGroupService(GroupService, GroupServiceName, GroupServiceDescription, GroupServiceStatus);
        }
        /// <summary>
        /// chinh sua nhom dich vu da co san trong he thong
        /// </summary>
        /// <param name="serviceid"></param>
        /// <param name="servicename"></param>
        /// <param name="servicedescription"></param>
        /// <param name="trangthais"></param>
        public static void EditGroupService(string GroupService, string GroupServiceName, string GroupServiceDescription, bool GroupServiceStatus)
        {
            DA.QuanTriHeThong.GroupService_DA.EditGroupService(GroupService, GroupServiceName, GroupServiceDescription, GroupServiceStatus);
        }
        /// <summary>
        /// lay ra 1 nhom dich vu trong danh sach
        /// </summary>
        /// <param name="tenviettats"></param>
        /// <returns></returns>
        public static List<GroupService_DO> Get_GroupService(string tenviettats)
        {
            return DA.QuanTriHeThong.GroupService_DA.Get_GroupService(tenviettats);
        }
        /// <summary>
        /// search nhom dich vu trong dnah sach
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static List<GroupService_DO> SearchGroupService(string ID)
        {
            return DA.QuanTriHeThong.GroupService_DA.SearchTypeService(ID);
        }
    }
}
