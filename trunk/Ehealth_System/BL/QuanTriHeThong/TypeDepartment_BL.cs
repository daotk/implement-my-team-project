using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using DA.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
   public class TypeDepartment_BL
    {
        public static List<TypeDepartment_DO> GetAllDepartment()
        {
            return DA.QuanTriHeThong.TypeDepartment_DA.GetAllDepartments();
        }

       /// <summary>
       /// thêm loại phòng ban mới
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
        public static int add(String ID, String name, String desscription, bool status)
        {

            return DA.QuanTriHeThong.TypeDepartment_DA.add(ID, name, desscription, status);

        }

       /// <summary>
       /// Chỉnh sửa loại phòng ban
       /// </summary>
       /// <param name="ID"></param>
       /// <param name="name"></param>
       /// <param name="desscription"></param>
       /// <param name="status"></param>
       /// <returns></returns>
        public static int edit(String ID, String name, String desscription, bool status)
        {

           return DA.QuanTriHeThong.TypeDepartment_DA.edit(ID, name, desscription, status);

        }

       /// <summary>
       /// Tìm kiếm loại phòng ban theo tên
       /// </summary>
       /// <param name="name"></param>
       /// <returns></returns>
        public static List<TypeDepartment_DO> SearchTypeDepart( String name)
        {

          return  TypeDepartment_DA.SearchTypeDepart(name);

        }


    }
}//end class
