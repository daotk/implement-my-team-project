using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;
using DA;

namespace BL.QuanTriHeThong
{
   public class Department_BL
    {
       public List<Department_DO> GetAllDepart() 
       {
           return Department_DA.GetAllDeparts();
       }

       public static int add(String ID, String name, String DepartmentID, String desscription, bool status)
       {
           return Department_DA.add(ID, name, DepartmentID, desscription, status);
       }


       public static void edit(String ID, String name, String DepartmentID, String desscription, bool status)
       {
           Department_DA.edit(ID, name, DepartmentID, desscription, status);
       }


       public static List<Department_DO> SearchDepart(String name)
       {
           return Department_DA.SearchDepartment(name);
       }


       public static List<Department_DO> SearchDepartByBoth(String name, String city)
       {
           return Department_DA.SearchDepartByBoth(name, city);
       }


       public static List<Department_DO> SearchDistrByDeparttype(String city)
       {
           return Department_DA.SearchDistrByDeparttype(city);
       }



    }
}
