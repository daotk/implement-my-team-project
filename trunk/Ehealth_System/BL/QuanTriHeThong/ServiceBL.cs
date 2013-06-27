﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;
namespace BL.QuanTriHeThong
{
    public class ServiceBL
    {
        public static List<ServiceDO> GetService()
        {
            return DA.QuanTriHeThong.ServiceDA.GetService(); 
        }
        public static void CreateService(string serviceid, string servicegroupid, string servicename, string servicecost, string servicedescription, bool trangthais)
        { 
        DA.QuanTriHeThong.ServiceDA.CreateService( serviceid,  servicegroupid,  servicename,  servicecost,  servicedescription,  trangthais);
        }
        public static void EditService(string serviceid, string servicegroupid, string servicename, string servicecost, string servicedescription, bool trangthais)
        {
        DA.QuanTriHeThong.ServiceDA.EditService(serviceid, servicegroupid, servicename, servicecost, servicedescription, trangthais);
        }
        public static List<ServiceDO> Get_Service(string tenviettats)
        {
        return DA.QuanTriHeThong.ServiceDA.Get_Service(tenviettats);
        }
    }
}