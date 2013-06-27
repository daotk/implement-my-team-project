using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
namespace DA.QuanTriHeThong
{
    public class ServiceDA
    {
        public static List<ServiceDO> GetService()
        {
            List<ServiceDO> dsusergroup = new List<ServiceDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Service_Info select u;
                foreach (var row in query)
                {
                    ServiceDO us = new ServiceDO();
                    us.serviceid_ = row.SERVICEID;
                    us.servicegroupid_ = row.SERVICEGROUPID;
                    us.servicename_ = row.SERVICENAME;
                    us.servicedescription_ = row.SERVICEDESCRIPTION;
                    us.servicecost_ = row.SERVICECOST;
                    us.servicestatus_ = row.SERVICESTATUS;

                    dsusergroup.Add(us);
                }
            }
            return dsusergroup;
        }

        //Create service group
        public static void CreateService(string serviceid, string servicegroupid, string servicename, string servicecost,string servicedescription, bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                Entity.Service_Info user = new Entity.Service_Info();
                user.SERVICEID = serviceid;
                user.SERVICEGROUPID = servicegroupid;
                user.SERVICENAME = servicename;
                user.SERVICECOST = servicecost;
                user.SERVICEDESCRIPTION = servicedescription;
                user.SERVICESTATUS = trangthais;
                dk.Service_Info.AddObject(user);
                dk.SaveChanges();
            }
        }
        // End create service

        public static void EditService(string serviceid, string servicegroupid, string servicename, string servicecost, string servicedescription, bool trangthais)
        {
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = (from u in dk.Service_Info
                             where u.SERVICEID == serviceid
                             select u).First();
                query.SERVICEID = serviceid;
                query.SERVICEGROUPID = servicegroupid;
                query.SERVICENAME = servicename;
                query.SERVICECOST = servicecost;
                query.SERVICEDESCRIPTION = servicedescription;
                query.SERVICESTATUS = trangthais;


                dk.SaveChanges();
            }
        }
        //End Edit service

        public static List<ServiceDO> Get_Service(string tenviettats)
        {
            List<ServiceDO> serviceinfo = new List<ServiceDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.Service_Info where u.SERVICEID == tenviettats select u;
                foreach (var row in query)
                {
                    ServiceDO us = new ServiceDO();
                    us.serviceid_ = row.SERVICEID;
                    us.servicegroupid_ = row.SERVICEGROUPID;
                    us.servicename_ = row.SERVICENAME;
                    us.servicecost_ = row.SERVICECOST;
                    us.servicedescription_ = row.SERVICEDESCRIPTION;
                    us.servicestatus_ = row.SERVICESTATUS;

                    serviceinfo.Add(us);
                }
            }
            return serviceinfo;
        }
        
    }
}
