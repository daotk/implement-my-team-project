using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
namespace DA.QuanTriHeThong
{
    public class GroupService_DA
    {
        public static List<GroupService_DO> GetGroupService()
        {
            List<GroupService_DO> dsGroupService = new List<GroupService_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info select u;
                foreach (var row in query)
                {
                    GroupService_DO us = new GroupService_DO();
                    us._SERVICEGROUPID = row.SERVICEGROUPID;
                    us._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    us._SERVICEBROUPDESCRIPTION = row.SERVICEBROUPDESCRIPTION;
                    us._SERVICEGROUPSTATUS = row.SERVICEGROUPSTATUS;
                    dsGroupService.Add(us);
                }
                return dsGroupService;
            }
        }
        //Create service group
        public static void CreateService(string serviceid, string servicename, string servicedescription, bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.ServiceGroup_Info user = new Entity.ServiceGroup_Info();
                user.SERVICEGROUPID = serviceid;
                user.SERVICEGROUPNAME = servicename;
                user.SERVICEBROUPDESCRIPTION = servicedescription;
                user.SERVICEGROUPSTATUS = trangthais;
                dk.ServiceGroup_Info.AddObject(user);
                dk.SaveChanges();
            }
        }
        // End create service

        public static void EditService(string serviceid, string servicename, string servicedescription, bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.ServiceGroup_Info
                             where u.SERVICEGROUPID == serviceid
                             select u).First();
                query.SERVICEGROUPID = serviceid;
                query.SERVICEGROUPNAME = servicename;
                query.SERVICEBROUPDESCRIPTION = servicedescription;
                query.SERVICEGROUPSTATUS = trangthais;


                dk.SaveChanges();
            }
        }
        //End Edit service

        public static List<GroupService_DO> Get_GroupService(string tenviettats)
        {
            List<GroupService_DO> serviceinfo = new List<GroupService_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.ServiceGroup_Info where u.SERVICEGROUPID == tenviettats select u;
                foreach (var row in query)
                {
                    GroupService_DO us = new GroupService_DO();
                    us._SERVICEGROUPID = row.SERVICEGROUPID;
                    us._SERVICEGROUPNAME = row.SERVICEGROUPNAME;
                    us._SERVICEBROUPDESCRIPTION = row.SERVICEBROUPDESCRIPTION;
                    us._SERVICEGROUPSTATUS = row.SERVICEGROUPSTATUS;
                    serviceinfo.Add(us);
                }
            }
            return serviceinfo;
        }
    }
}
