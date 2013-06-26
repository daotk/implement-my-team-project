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
        public List<TypeDepartment_DO> GetAllDepartment()
        {
            return TypeDepartment_DA.GetAllDepartments();
        }
        public static int add(String ID, String name, String desscription, bool status)
        {

            return TypeDepartment_DA.add(ID, name, desscription, status);

        }
        public static void edit(String ID, String name, String desscription, bool status)
        {

            TypeDepartment_DA.edit(ID, name, desscription, status);

        }
    }
}
