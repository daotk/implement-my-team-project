using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using System.Data.Entity;
using System.Data.Objects;
using DO;


namespace DA.ThuNgan
{
    public class TypeDepartment_TN_DA
    {     
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public static List<DO.ThuNgan.TypeDepartment_TN_DO> GetTypeDepartment() 
        {
            List<DO.ThuNgan.TypeDepartment_TN_DO> timkiem = new List<DO.ThuNgan.TypeDepartment_TN_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DepartmentType_Info select u;

                foreach (var row in query)
                {
                    DO.ThuNgan.TypeDepartment_TN_DO depart = new DO.ThuNgan.TypeDepartment_TN_DO();
                    depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                    depart._DEPARTMENTNAME = row.DEPARTMENTTYPENAME;
                    depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTTYPEDESCRIPTION;
                    depart._DEPARTMENTSTATUS = row.DEPARTMENTSTATUS;
                    timkiem.Add(depart);
                }
                return timkiem;
            }
        
        }//end
    }
}//end class
