using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA
{
   public class Department_DA
    {
       public static List<Department_DO> GetAllDeparts()
       {
           List<Department_DO> ListDepartment = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO depart = new Department_DO();
                   depart._DEPARTMENTID = row.DEPARTMENTID;
                   depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var departmenttypename = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   depart._DEPARTMENTTYPENAME = departmenttypename.DEPARTMENTTYPENAME;
                   depart._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   depart._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   ListDepartment.Add(depart);
               }
               return ListDepartment;
           }

       }


       public static int add(String ID, String name, String DEPARTMENTTYPEID, String desscription, bool status)
       {

           using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
           {
               Entity.Department_Info depart = new Entity.Department_Info();
               depart.DEPARTMENTID = ID;
               depart.DEPARTMENTTYPEID = DEPARTMENTTYPEID;

               depart.DEPARTMENTNAME = name;
               depart.DEPARTMENTDESCRIPTION = desscription;
               depart.DEPARTMENTSTATUS = status;
               entity.Department_Info.AddObject(depart);
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

       public static void edit(String ID, String name, String DEPARTMENTTYPEID, String desscription, bool status)
       {
           using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
           {
               var depart = entity.Department_Info.Single(p => p.DEPARTMENTID == ID);
               depart.DEPARTMENTID = ID;
               depart.DEPARTMENTTYPEID = DEPARTMENTTYPEID;
               depart.DEPARTMENTNAME = name;
               depart.DEPARTMENTDESCRIPTION = desscription;
               depart.DEPARTMENTSTATUS = status;
               entity.SaveChanges();
           }
       }



       public static List<Department_DO> SearchDepartment(string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTNAME.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var cityname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = cityname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }
       }


       public static List<Department_DO> SearchDistrByDeparttype(string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTTYPEID.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var departname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = departname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }

       }



       public static List<Department_DO> SearchDepartByBoth(String text, string Search)
       {
           List<Department_DO> timkiem = new List<Department_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where (u.DEPARTMENTNAME.Contains(text)) && (u.DEPARTMENTTYPEID.Contains(Search)) select u;
               var query1 = from u in dk.DepartmentType_Info
                            select u;
               foreach (var row in query)
               {
                   Department_DO search = new Department_DO();
                   search._DEPARTMENTID = row.DEPARTMENTID;
                   search._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   search._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   var cityname = query1.Single(p => p.DEPARTMENTTYPEID == row.DEPARTMENTTYPEID);
                   search._DEPARTMENTTYPENAME = cityname.DEPARTMENTTYPENAME;
                   search._DEPARTMENTDESCRIPTION = row.DEPARTMENTDESCRIPTION;
                   search._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   timkiem.Add(search);
               }
               return timkiem;
           }

       }
    }
}
