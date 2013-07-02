using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA.QuanTriHeThong;
using DO.QuanTriHeThong;
using DA;

namespace BL.ThuNgan
{
   public class Department_TN_BL
    {
       public static List<DO.ThuNgan.Department_TN_DO> GetAllDepart() 
       {
           return DA.ThuNgan.Department_TN_DA.GetAllDepart();
       }




    }
}//end class
