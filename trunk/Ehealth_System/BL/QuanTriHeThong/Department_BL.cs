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


       public static void edit(String ID, String name, String CityID, String desscription, bool status)
       {
           District_DA.edit(ID, name, CityID, desscription, status);
       }


       public static List<District_DO> SearchDistrict(String name)
       {
           return District_DA.SearchDistrict(name);
       }


       public static List<District_DO> SearchDistrictByBoth(String name, String city)
       {
           return District_DA.SearchDistrictByBoth(name, city);
       }


       public static List<District_DO> SearchDistrictByCity(String city)
       {
           return District_DA.SearchDistrictByCity(city);
       }



    }
}
