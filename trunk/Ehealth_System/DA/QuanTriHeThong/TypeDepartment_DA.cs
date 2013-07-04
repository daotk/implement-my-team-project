using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DO.QuanTriHeThong;
using System.Data.Entity;
using System.Data.Objects;
using DO;


namespace DA.QuanTriHeThong
{
    public class TypeDepartment_DA
    {
        public static List<TypeDepartment_DO> GetAllDepartments()
        {
            List<TypeDepartment_DO> ListDeparttype = new List<TypeDepartment_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DepartmentType_Info select u;

                foreach (var row in query)
                {
                    TypeDepartment_DO depart = new TypeDepartment_DO();
                    depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                    depart._DEPARTMENTNAME = row.DEPARTMENTTYPENAME;
                    depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTTYPEDESCRIPTION;
                    depart._DEPARTMENTTYPESTATUS = row.DEPARTMENTSTATUS;
                    ListDeparttype.Add(depart);
                }
                return ListDeparttype;
            }
        }//end

        

        /// <summary>
        /// Thêm loại phòng ban mới
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="name"></param>
        /// <param name="desscription"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static int add(String ID, String name, String desscription, bool status)
        {

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                Entity.DepartmentType_Info depart = new Entity.DepartmentType_Info();
                depart.DEPARTMENTTYPEID = ID;
                depart.DEPARTMENTTYPENAME = name;
                depart.DEPARTMENTTYPEDESCRIPTION = desscription;
                depart.DEPARTMENTSTATUS = status;
                entity.DepartmentType_Info.AddObject(depart);
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
        }//end



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

            using (Entity.EHealthSystemEntities entity = new Entity.EHealthSystemEntities())
            {
                var depart = entity.DepartmentType_Info.Single(p => p.DEPARTMENTTYPEID == ID);

                depart.DEPARTMENTTYPEID = ID;
                depart.DEPARTMENTTYPENAME = name;
                depart.DEPARTMENTTYPEDESCRIPTION = desscription;
                depart.DEPARTMENTSTATUS = status;

                //entity.SaveChanges();
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
        }//end

        /// <summary>
        /// Tìm kiếm loại phòng ban theo tên
        /// </summary>
        /// <param name="Search"></param>
        /// <returns></returns>
        public static List<TypeDepartment_DO> SearchTypeDepart(string Search) 
        {
            List<TypeDepartment_DO> timkiem = new List<TypeDepartment_DO>();
            using (Entity.EHealthSystemEntities dk = new Entity.EHealthSystemEntities())
            {
                var query = from u in dk.DepartmentType_Info where (u.DEPARTMENTTYPENAME.Contains(Search)) select u;

                foreach (var row in query)
                {
                    TypeDepartment_DO depart = new TypeDepartment_DO();
                    depart._DEPARTMENTTYPEID = row.DEPARTMENTTYPEID;
                    depart._DEPARTMENTNAME = row.DEPARTMENTTYPENAME;
                    depart._DEPARTMENTDESCRIPTION = row.DEPARTMENTTYPEDESCRIPTION;
                    depart._DEPARTMENTTYPESTATUS = row.DEPARTMENTSTATUS;
                    timkiem.Add(depart);
                }
                return timkiem;
            }
        
        }//end
    }
}//end class
