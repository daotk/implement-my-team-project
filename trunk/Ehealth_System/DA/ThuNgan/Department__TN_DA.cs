using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;

namespace DA.ThuNgan
{
   public class Department_TN_DA
    {
       public static List<DO.ThuNgan.Department_TN_DO> GetAllDepart()
       {
           List<DO.ThuNgan.Department_TN_DO> ListDepartment = new List<DO.ThuNgan.Department_TN_DO>();
           using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
           {
               var query = from u in dk.Department_Info where u.DEPARTMENTSTATUS ==true select u;
               foreach (var row in query)
               {
                   DO.ThuNgan.Department_TN_DO depart = new DO.ThuNgan.Department_TN_DO();
                   depart._DEPARTMENTID = row.DEPARTMENTID;
                   depart._DEPARTMENTNAME = row.DEPARTMENTNAME;
                   depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                   depart._DEPARTMENTTYPENAME = row.DepartmentType_Info.DEPARTMENTTYPENAME;
                   depart._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                   ListDepartment.Add(depart);
               }
               return ListDepartment;
           }

       }//end


       
    }
}//end class
