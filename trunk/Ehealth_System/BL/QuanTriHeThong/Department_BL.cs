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

       public static List<DO.QuanTriHeThong.TypeDepartment_DO> GetAllDepart1()
       {
           return Department_DA.GetAllDeparts1();
       }

       /// <summary>
       /// thêm phòng ban mới
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="DepartmentID"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
       public static int add(String ID, String name, String DepartmentID, String desscription, bool status)
       {
           return Department_DA.add(ID, name, DepartmentID, desscription, status);
       }

       /// <summary>
       /// chỉnh sửa phòng ban
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="DepartmentID"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
       public static int edit(String ID, String name, String DepartmentID, String desscription, bool status)
       {
           return Department_DA.edit(ID, name, DepartmentID, desscription, status);
       }

       /// <summary>
       /// tìm kiếm phòng ban theo tên
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDepart(String name)
       {
           return Department_DA.SearchDepartment(name);
       }


       /// <summary>
       /// tìm kiếm phòng ban theo từ khóa và theo tên loại phòng ban
       /// </summary>
       /// <param name="name"></param>
       /// <param name="city"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDepartByBoth(String name, String city)
       {
           return Department_DA.SearchDepartByBoth(name, city);
       }

       /// <summary>
       /// tìm kiếm theo loại phòng ban
       /// </summary>
       /// <param name="city"></param>
       /// <returns></returns>
       public static List<Department_DO> SearchDistrByDeparttype(String city)
       {
           return Department_DA.SearchDistrByDeparttype(city);
       }



    }
}//end class
