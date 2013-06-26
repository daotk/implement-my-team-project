using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using DO.QuanTriHeThong;
using DO;

namespace DA.QuanTriHeThong
{
   public class DepartmentTypeDA
    {
       public static List<DepartmentTypeDO> GetAllDepartments()
        {
            List<DepartmentTypeDO> ListDeparttype = new List<DepartmentTypeDO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DepartmentType_Info select u;

                foreach (var row in query)
                {
                    DepartmentTypeDO depart = new DepartmentTypeDO();
                    depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                    depart._DEPARTMENTNAME = row.DEPARTMENTTYPENAME;
                    depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTTYPEDESCRIPTION;
                    depart._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                    ListDeparttype.Add(depart);
                }
                return ListDeparttype;
            }
        }

       public static int add(String ID, String name, String desscription, bool status)
       {

           using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
           {
               Entity.DepartmentType_Info depart = new Entity.DepartmentType_Info();
               depart.DEPARTMENTTYPEID = ID;
               depart.DEPARTMENTTYPENAME = name;
               depart.DEPARTMENTTYPEDESCRIPTION = desscription;
               depart.DEPARTMENTSTATUS = status;
               entity.DepartmentType_Info.AddObject(depart);
               try
               {
                   int num = entity.SaveChanges();
                   return num;
               }
               catch
               {
                   return -1;
               }

           }
       }



    }
}
