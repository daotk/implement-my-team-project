using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;

namespace BL.QuanTriHeThong
{
   public class DepartmentTypeBL
    {
        public List<DepartmentTypeDO> GetAllDepartment()
        {
            return DepartmentTypeDA.GetAllDepartments();
        }
        public static int add(String ID, String name, String desscription, bool status)
        {

            return DepartmentTypeDA.add(ID, name, desscription, status);

        }
        //public static void edit(String ID, String name, String desscription, bool status)
        //{

        //    DepartmentTypeDA.edit(ID, name, desscription, status);

        //}
    
    }
}
